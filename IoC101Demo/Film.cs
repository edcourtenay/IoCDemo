namespace IoC101Demo
{
    public class Film : IFilm
    {
        public string Name { get; set; }
        public string[] Director { get; set; }
        public int Year { get; set; }
    }
}