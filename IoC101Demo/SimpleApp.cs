using System;
using System.Linq;
using IoC101Demo.Filters;

namespace IoC101Demo;

public class SimpleApp
{
    private readonly IFilmRepository _filmRepository;
    private readonly IFilmFilter _filmFilter;
    private readonly IFilmSortStrategy _filmSortStrategy;

    public SimpleApp(IFilmRepository filmRepository, IFilmFilter filmFilter, IFilmSortStrategy filmSortStrategy)
    {
        _filmRepository = filmRepository;
        _filmFilter = filmFilter;
        _filmSortStrategy = filmSortStrategy;
    }

    public void Run()
    {
        var filteredFilms = _filmRepository.Films()
            .Where(_filmFilter.FilterFunction)
            .OrderBy(film => film, _filmSortStrategy)
            .ToArray();

        foreach (var filteredFilm in filteredFilms)
        {
            Console.WriteLine(filteredFilm);
        }
    }
}