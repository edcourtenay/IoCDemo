using IoC101Demo;
using IoC101Demo.Filters;
using IoC101Demo.Sorting;

var container = new Container();
container.Register<IFilmRepository, FilmRepository>();
container.Register<IFilmFilter, Since2000Filter>();
container.Register<IFilmSortStrategy, YearSort>();

var simpleApp = container.Resolve<SimpleApp>();
simpleApp.Run();
