using System;

namespace IoC101Demo
{
    public interface IFilmSortStrategy
    {
        Func<IFilm, int> OrderFunction { get; }
    }
}