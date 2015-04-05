using System;
using System.Linq;

namespace IoC101Demo
{
    public class SimpleApp
    {
        private readonly IFilmRepository _repository;
        private readonly IFilmFilter _filter;
        private readonly IFilmSortStrategy _filmSortStrategy;

        public SimpleApp(IFilmRepository repository, IFilmFilter filter, IFilmSortStrategy filmSortStrategy)
        {
            _repository = repository;
            _filter = filter;
            _filmSortStrategy = filmSortStrategy;
        }

        public void Run()
        {
            var filteredFilms = _repository.Films()
                .Where(_filter.FilterFunction)
                .OrderBy(_filmSortStrategy.OrderFunction)
                .ToArray();

            foreach (var filteredFilm in filteredFilms)
            {
                Console.WriteLine(filteredFilm);
            }
        }
    }
}