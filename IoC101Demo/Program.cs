using System;
using System.Linq;
using IoC101Demo.Filters;
using IoC101Demo.Sorting;

namespace IoC101Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new FilmRepository();
            var filter = new Since2000Filter();
            var filmSortStrategy = new YearSort();

            var filteredFilms = repository.Films()
                .Where(filter.FilterFunction)
                .OrderBy(film => film, filmSortStrategy)
                .ToArray();

            foreach (var filteredFilm in filteredFilms)
            {
                Console.WriteLine(filteredFilm);
            }

        }
    }
}
