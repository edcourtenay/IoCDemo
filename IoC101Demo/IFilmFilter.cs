using System;

namespace IoC101Demo
{
    internal interface IFilmFilter
    {
        Func<IFilm, bool> FilterFunction { get; }
    }
}