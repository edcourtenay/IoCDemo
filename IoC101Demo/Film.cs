using System;

namespace IoC101Demo
{
    public class Film
    {
        public string Name { get; init; }
        public int Year { get; init; }
        public string[] Director { get; init; }
        public string[] Actor { get; init; }

        public override string ToString()
        {
            return string.Format("{0} [{1}]: {2}", Name, String.Join(", ", Director), Year);
        }
    }
}