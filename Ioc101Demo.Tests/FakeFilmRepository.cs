using System.Collections.Generic;
using IoC101Demo;

namespace Ioc101Demo.Tests;

public class FakeFilmRepository : IFilmRepository
{
    public IEnumerable<Film> Films()
    {
        yield return new Film { Name = "Film1", Year = 1994, Director = new[] { "Director1" }, Actor = new[] { "Actor1" } };
        yield return new Film { Name = "Film2", Year = 1972, Director = new[] { "Director2","Director3" }, Actor = new[] { "Actor2" } };
        yield return new Film { Name = "Film3", Year = 1974, Director = new[] { "Director4" }, Actor = new[] { "Actor3", "Actor3" } };
    }
}