using System;

namespace IoC101Demo
{
    public interface IFilmFilter
    {
        Func<IFilm, bool> FilterFunction { get; }
    }
}