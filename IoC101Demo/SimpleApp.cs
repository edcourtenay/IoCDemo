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
            var filmSortStrategy = new FilmSortStrategy();

            var filteredFilms = repository.Films()
                .Where(filter.FilterFunction)
                .OrderBy(filmSortStrategy.OrderFunction)
                .ToArray();

            foreach (var filteredFilm in filteredFilms)
            {
                Console.WriteLine(filteredFilm);
            }
        }
    }
}