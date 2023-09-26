namespace IoC101Demo.Sorting;

public class YearSortDescending : IFilmSortStrategy
{
    public int Compare(Film x, Film y)
    {
        return y.Year.CompareTo(x.Year);
    }
}