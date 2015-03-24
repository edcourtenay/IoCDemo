using System;

namespace IoC101Demo
{
    internal class FilmSortStrategy : IFilmSortStrategy
    {
        public Func<IFilm, int> OrderFunction
        {
            get { return film => film.Year; }
        }
    }
}