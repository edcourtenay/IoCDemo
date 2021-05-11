#nullable enable
using System;
using IoC101Demo;
using IoC101Demo.Filters;
using Moq;
using Xunit;

namespace Ioc101Demo.Tests
{
    public class SimpleAppTest
    {
        [Fact]
        public static void RunShouldExecuteWithoutError()
        {
            var sut = new SimpleApp(new FakeFilmRepository(), 
                Mock.Of<IFilmFilter>(f => f.FilterFunction == new Func<Film, bool>(_ => true)), 
                Mock.Of<IFilmSortStrategy>());

            sut.Run();
        }
    }
}