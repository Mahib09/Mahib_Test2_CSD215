﻿// Define the discriminated union for Genre
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

// Define the Director record type
type Director = {
    Name: string
    Movies: int
}

// Define the Movie record type
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Define movie instances based on the provided table
let movies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDBRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }
]

// Print all movies with run length in minutes
printfn "All Movies:"
movies 
|> List.iter (fun movie -> printfn "Movie Name: %s | Run Length: %d minutes | Genre: %A | Director: %s | IMDB Rating: %.1f" 
                                    movie.Name 
                                    movie.RunLength 
                                    movie.Genre 
                                    movie.Director.Name 
                                    movie.IMDBRating)

// Filter movies with IMDB rating greater than 7.4
let probableOscarWinners =
    movies
    |> List.filter (fun movie -> movie.IMDBRating > 7.4)

// Print probable Oscar winners with director and IMDB rating
printfn "\nProbable Oscar Winners with Director and IMDB Rating:"
probableOscarWinners 
|> List.iter (fun movie -> printfn "Movie Name: %s | Director: %s | IMDB Rating: %.1f" movie.Name movie.Director.Name movie.IMDBRating)

// Function to convert minutes to hours and minutes format
let convertToHoursMinutes (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes
// Function to print movie name and run length in hours and minutes format
let printMovieNameAndTime (movie: Movie) =
    printfn "Movie Name: %s= %s" movie.Name (convertToHoursMinutes movie.RunLength)

// Print movie names and run length in hours and minutes format
printfn "\nMovies with Run Length in Hours and Minutes:"
movies 
|> List.iter printMovieNameAndTime
