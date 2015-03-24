namespace IoC101Demo
{
    internal class Since2000Filter : IFilmFilter
    {
        public bool Filter(IFilm film)
        {
            return film.Year >= 2000;
        }
    }
}