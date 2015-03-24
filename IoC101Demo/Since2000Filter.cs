using System;

namespace IoC101Demo
{
    internal class Since2000Filter : IFilmFilter
    {
        public Func<IFilm, bool> FilterFunction
        {
            get { return film => film.Year >= 2000; }
        }
    }
}