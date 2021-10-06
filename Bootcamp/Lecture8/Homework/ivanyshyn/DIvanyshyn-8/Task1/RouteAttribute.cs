using System;

namespace DIvanyshyn_8.AssembliesExample
{
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class RouteAttribute : Attribute
    {



        // This is a positional argument
        public RouteAttribute(string positionalString)
        {
            this.Name = positionalString;
        }

        public string Name { get; init; }
    }
}