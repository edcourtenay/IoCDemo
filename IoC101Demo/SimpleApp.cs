using System;
using System.Linq;

namespace IoC101Demo
{
    internal class SimpleApp
    {
        public void Run()
        {
            var repository = new FilmRepository();
            var filter = new Since2000Filter();

            var filteredFilms = repository.Films()
                .Where(film => filter.Filter(film))
                .ToArray();

            foreach (var filteredFilm in filteredFilms)
            {
                Console.WriteLine(filteredFilm);
            }
        }
    }
}