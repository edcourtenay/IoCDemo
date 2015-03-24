namespace IoC101Demo
{
    public interface IFilm
    {
        string Name { get; }
        string[] Director { get; }
        int Year { get; }
    }
}