using System;
using System.Linq;
using IoC101Demo;
using Moq;
using NUnit.Framework;

namespace Ioc101Demo.Tests
{
    [TestFixture]
    public class AppTest
    {
        [Test]
        public static void RunShouldExecuteWithoutError()
        {
            var filmFilter = Mock.Of<IFilmFilter>(f => f.FilterFunction == (Func<IFilm, bool>) (film => true));
            var filmSortStrategy = Mock.Of<IFilmSortStrategy>(s => s.OrderFunction == (Func<IFilm, int>) (film => 0));
            var sut = new SimpleApp(Mock.Of<IFilmRepository>(), filmFilter, filmSortStrategy);

            sut.Run();
        }
    }
}