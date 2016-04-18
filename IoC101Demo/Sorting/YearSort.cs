namespace IoC101Demo.Sorting
{
    public class YearSort : IFilmSortStrategy
    {
        public int Compare(Film x, Film y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
}