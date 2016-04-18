using System;

namespace IoC101Demo
{
    public class Film
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string[] Director { get; set; }
        public string[] Actor { get; set; }

        public override string ToString()
        {
            return string.Format("{0} [{1}]: {2}", Name, String.Join(", ", Director), Year);
        }
    }
}