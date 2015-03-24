using System.Collections.Generic;

namespace IoC101Demo
{
    public class FilmRepository : IFilmRepository
    {
        public IEnumerable<IFilm> Films()
        {
            yield return new Film { Name = "The Shawshank Redemption", Director = new[] { "Frank Darabont" }, Year = 1994 };
            yield return new Film { Name = "The Godfather", Director = new[] { "Francis Ford Coppola" }, Year = 1972 };
            yield return new Film { Name = "The Godfather Part 2", Director = new[] { "Francis Ford Coppola" }, Year = 1974 };
            yield return new Film { Name = "The Dark Knight", Director = new[] { "Christopher Nolan" }, Year = 2008 };
            yield return new Film { Name = "Pulp Fiction", Director = new[] { "Quentin Tarantino" }, Year = 1994 };
            yield return new Film { Name = "Schindler's List", Director = new[] { "Steven Spielberg" }, Year = 1993 };
            yield return new Film { Name = "12 Angry Men", Director = new[] { "Sidney Lumet" }, Year = 1957 };
            yield return new Film { Name = "The Good, the Bad and the Ugly", Director = new[] { "Sergio Leone" }, Year = 1966 };
            yield return new Film { Name = "The Lord of the Rings: The Return of the King", Director = new[] { "Peter Jackson" }, Year = 2003 };
            yield return new Film { Name = "Fight Club", Director = new[] { "David Fincher" }, Year = 1999 };
            yield return new Film { Name = "The Lord of the Rings: The Fellowship of the Ring", Director = new[] { "Peter Jackson" }, Year = 2001 };
            yield return new Film { Name = "Star Wars V: The Empire Strikes Back", Director = new[] { "Irvin Kershner" }, Year = 1980 };
            yield return new Film { Name = "Forrest Gump", Director = new[] { "Robert Zemeckis" }, Year = 1994 };
            yield return new Film { Name = "Inception", Director = new[] { "Christopher Nolan" }, Year = 2010 };
            yield return new Film { Name = "One Flew Over the Cuckoo's Nest", Director = new[] { "Milos Forman" }, Year = 1975 };
            yield return new Film { Name = "The Lord of the Rings: The Two Towers", Director = new[] { "Peter Jackson" }, Year = 2002 };
            yield return new Film { Name = "Goodfellas", Director = new[] { "Martin Scorsese" }, Year = 1990 };
            yield return new Film { Name = "The Matrix", Director = new[] { "Andy Wachowski", "Lana Wachowski" }, Year = 1999 };
            yield return new Film { Name = "Star Wars IV: A New Hope", Director = new[] { "George Lucas" }, Year = 1977 };
            yield return new Film { Name = "Seven Samurai", Director = new[] { "Akira Kurosawa" }, Year = 1954 };
            yield return new Film { Name = "City of God", Director = new[] { "Fernanando Meirelles" }, Year = 2002 };
            yield return new Film { Name = "Interstellar", Director = new[] { "Christopher Nolan" }, Year = 2014 };
            yield return new Film { Name = "Se7en", Director = new[] { "David Fincher" }, Year = 1995 };
            yield return new Film { Name = "The Usual Suspects", Director = new[] { "Bryan Singer" }, Year = 1995 };
            yield return new Film { Name = "The Silence of the Lambs", Director = new[] { "Jonathan Demme" }, Year = 1991 };
            yield return new Film { Name = "It's a Wonderful Life", Director = new[] { "Frank Capra" }, Year = 1946 };
            yield return new Film { Name = "Once Upon a Time in the West", Director = new[] { "Sergio Leone" }, Year = 1968 };
            yield return new Film { Name = "Léon", Director = new[] { "Luc Besson" }, Year = 1994 };
            yield return new Film { Name = "Life is Beautiful", Director = new[] { "Roberto Benigni" }, Year = 1997 };
            yield return new Film { Name = "Casablanca", Director = new[] { "Michael Curtiz" }, Year = 1942 };
        }
    }
}