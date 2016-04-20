using System;
using System.Collections.Generic;
using System.Linq;
using IoC101Demo.Filters;
using IoC101Demo.Sorting;

namespace IoC101Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Register<IFilmRepository, FilmRepository>();
            container.Register<IFilmFilter, Since2000Filter>();
            container.Register<IFilmSortStrategy, YearSort>();

            var simpleApp = container.Resolve<SimpleApp>();
            simpleApp.Run();
        }
    }

    public static class ServiceLocator
    {
        private static Dictionary<Type, Func<object>> _dictionary 
            = new Dictionary<Type, Func<object>>(); 

        public static void Register<T>(Func<T> func) where T : class 
        {
            _dictionary.Add(typeof(T), func);
        }

        public static T Resolve<T>()
        {
            return (T) _dictionary[typeof (T)]();
        }
    }

    public class Container
    {
        private Dictionary<Type, Type> _dictionary 
            = new Dictionary<Type, Type>(); 

        public void Register<TSource, TImplementation>() where TImplementation : TSource
        {
            Register(typeof(TSource), typeof(TImplementation));
        }

        private void Register(Type sourceType, Type implementationType)
        {
            _dictionary.Add(sourceType, implementationType);
        }

        public T Resolve<T>()
        {
            return (T) Resolve(typeof (T));
        }

        private object Resolve(Type sourceType)
        {
            if (_dictionary.ContainsKey(sourceType))
                return CreateType(_dictionary[sourceType]);

            return CreateType(sourceType);
        }

        private object CreateType(Type sourceType)
        {
            var constructorInfo = sourceType.GetConstructors()
                .OrderByDescending(info => info.GetParameters().Length)
                .First();

            var parameters = constructorInfo.GetParameters()
                .Select(p => p.ParameterType)
                .Select(Resolve)
                .ToArray();

            return constructorInfo.Invoke(parameters);
        }
    }
}
