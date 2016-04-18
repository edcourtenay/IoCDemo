using System;
using System.Linq;

namespace IoC101Demo.Filters
{
    internal class ChristopherNolanFilter : IFilmFilter
    {
        public Func<Film, bool> FilterFunction => 
            film => film.Director.Contains("Christopher Nolan");
    }
}