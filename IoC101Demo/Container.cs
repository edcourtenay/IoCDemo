using System;
using System.Collections.Generic;
using System.Linq;

namespace IoC101Demo;

public class Container
{
    private readonly Dictionary<Type, Type> _dictionary = new();

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
        return CreateType(_dictionary.TryGetValue(sourceType, out var value)
            ? value
            : sourceType);
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