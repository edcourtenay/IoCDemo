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
            var sut = new SimpleApp(new FakeFilmRepository(), Mock.Of<IFilmFilter>(), Mock.Of<IFilmSortStrategy>());

            //ServiceLocator.Register<IFilmRepository>(() => Mock.Of<IFilmRepository>());
            //ServiceLocator.Register<IFilmFilter>(() => Mock.Of<IFilmFilter>());
            //ServiceLocator.Register<IFilmSortStrategy>(() => Mock.Of<IFilmSortStrategy>());

            sut.Run();
        }
    }
}