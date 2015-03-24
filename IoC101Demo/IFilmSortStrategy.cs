using System;

namespace IoC101Demo
{
    internal interface IFilmSortStrategy
    {
        Func<IFilm, int> OrderFunction { get; }
    }
}