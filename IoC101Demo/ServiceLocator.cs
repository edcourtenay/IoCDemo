using System;
using System.Collections.Generic;

namespace IoC101Demo
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, Func<object>> _serviceMap = 
            new Dictionary<Type, Func<object>>();
        
        public static void Register<T>(Func<object> func)
        {
            _serviceMap[typeof (T)] = func;
        }

        public static T Resolve<T>()
        {
            return (T) _serviceMap[typeof (T)]();
        }
    }
}