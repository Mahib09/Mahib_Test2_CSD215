type AllGenre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport
type MovieDirector = {
    Name: string
    Movies: int
}
type Movie = {
    Name: string
    RunLength: int
    Genre: AllGenre
    Director: MovieDirector
    IMDBRating: float
}
let listOfMovies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDBRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }
]
printfn "All Movies:"
listOfMovies 
|> List.iter (fun listOfMovies -> printfn "Movie Name: %s | Run Length: %d minutes | Genre: %A | Director: %s | IMDB Rating: %.1f" 
                                    listOfMovies.Name 
                                    listOfMovies.RunLength 
                                   listOfMovies.Genre 
                                    listOfMovies.Director.Name 
                                    listOfMovies.IMDBRating)

let probableOscarWinners =
    listOfMovies
    |> List.filter (fun listOfMovies -> listOfMovies.IMDBRating > 7.4)
printfn "\nProbable Oscar Winners with Director and IMDB Rating:"
probableOscarWinners 
|> List.iter (fun listOfMovies -> printfn "Movie Name: %s | Director: %s | IMDB Rating: %.1f" listOfMovies.Name listOfMovies.Director.Name listOfMovies.IMDBRating)
let convertToHoursMinutes (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let printMovieNameAndTime (movie: Movie) =
    printfn "Movie Name: %s | Length: %s" movie.Name (convertToHoursMinutes movie.RunLength)

printfn "\nMovies with Run Length in Hours and Minutes:"
listOfMovies 
|> List.map printMovieNameAndTime

