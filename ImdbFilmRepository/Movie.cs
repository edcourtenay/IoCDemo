using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace ImdbFilmRepository
{

    public class Rootobject
    {
        public Movie[] Property1 { get; set; }
    }

    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Metascore { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string ImdbId { get; set; }
        public string Response { get; set; }
    }


    public class MovieRepository
    {
        public IEnumerable<Movie> GetMovies()
        {
            Movie[] movies;
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ImdbFilmRepository.Assets.Top250Movies.json"))
            using (var reader = new StreamReader(stream))
            {
                JsonSerializer serializer = new JsonSerializer();
                movies = serializer.Deserialize<Movie[]>(new JsonTextReader(reader));
            }

            return movies;
        }
    }
}
