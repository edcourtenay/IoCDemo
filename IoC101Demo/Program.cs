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
            var simpleApp = new SimpleApp();
            simpleApp.Run();
        }
    }
}
