using System;
using System.Collections.Generic;

namespace IoC101Demo;

public record Film
{
    public string Name { get; init; }
    public int Year { get; init; }
    public string[] Director { get; init; }
    public string[] Actor { get; init; }

    public override string ToString()
    {
        return $"{Name} [{string.Join(", ", Director)}]: {Year}";
    }
}