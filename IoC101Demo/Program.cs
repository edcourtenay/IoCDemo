using System.ComponentModel;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace IoC101Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();

            container.Register<IFilmRepository, FilmRepository>();
            container.Register<IFilmFilter, Since2000Filter>();
            container.Register<IFilmSortStrategy, FilmSortStrategy>();
            
            SimpleApp simpleApp = container.Resolve<SimpleApp>();
            simpleApp.Run();
        }
    }
}
