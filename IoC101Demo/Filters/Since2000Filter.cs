using System;

namespace IoC101Demo.Filters;

internal class Since2000Filter : IFilmFilter
{
    public Func<Film, bool> FilterFunction
        => film => film.Year >= 2000;
}