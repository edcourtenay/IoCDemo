using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace ImdbFilmRepository;

public class Rootobject
{
    public Movie[] Property1 { get; set; }
}

public record Movie
{
    public string Title { get; init; }
    public string Year { get; init; }
    public string Rated { get; init; }
    public string Released { get; init; }
    public string Runtime { get; init; }
    public string Genre { get; init; }
    public string Director { get; init; }
    public string Writer { get; init; }
    public string Actors { get; init; }
    public string Plot { get; init; }
    public string Language { get; init; }
    public string Country { get; init; }
    public string Awards { get; init; }
    public string Poster { get; init; }
    public string Metascore { get; init; }
    public string ImdbRating { get; init; }
    public string ImdbVotes { get; init; }
    public string ImdbId { get; init; }
    public string Response { get; init; }
}


public class MovieRepository
{
    public IEnumerable<Movie> GetMovies()
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ImdbFilmRepository.Assets.Top250Movies.json");
        using var reader = new StreamReader(stream ?? throw new InvalidOperationException());
        JsonSerializer serializer = new JsonSerializer();
        var movies = serializer.Deserialize<Movie[]>(new JsonTextReader(reader));

        return movies;
    }
}