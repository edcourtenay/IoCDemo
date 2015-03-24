using System.Collections.Generic;

namespace IoC101Demo
{
    public interface IFilmRepository
    {
        IEnumerable<IFilm> Films();
    }
}