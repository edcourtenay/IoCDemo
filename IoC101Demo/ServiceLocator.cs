using System;
using System.Collections.Generic;

namespace IoC101Demo;

public static class ServiceLocator
{
    private static readonly Dictionary<Type, Func<object>> Dictionary = new();

    public static void Register<T>(Func<T> func) where T : class
    {
        Dictionary.Add(typeof(T), func);
    }

    public static T Resolve<T>()
    {
        return (T) Dictionary[typeof (T)]();
    }
}