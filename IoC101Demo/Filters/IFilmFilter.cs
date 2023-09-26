using System;

namespace IoC101Demo.Filters;

public interface IFilmFilter
{
    Func<Film, bool> FilterFunction { get; }
}