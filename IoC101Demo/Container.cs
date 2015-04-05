using System;
using System.Collections.Generic;
using System.Linq;

namespace IoC101Demo
{
    public class Container
    {
        private Dictionary<Type, Type> _typeMap = new Dictionary<Type, Type>(); 
        
        public void Register<TBase, TImplementation>()
        {
            Register(typeof (TBase), typeof (TImplementation));
        }

        public void Register(Type baseType, Type implType)
        {
            _typeMap[baseType] = implType;
        }

        public T Resolve<T>()
        {
            return (T) Resolve(typeof (T));
        }

        public object Resolve(Type baseType)
        {
            if (_typeMap.ContainsKey(baseType))
                return CreateInstance(_typeMap[baseType]);

            return CreateInstance(baseType);
        }

        private object CreateInstance(Type baseType)
        {
            var constructor = baseType.GetConstructors()
                .OrderByDescending(info => info.GetParameters().Count())
                .First();

            var parameters = constructor.GetParameters()
                .Select(info => Resolve(info.ParameterType))
                .ToArray();

            return constructor.Invoke(parameters);
        }
    }
}