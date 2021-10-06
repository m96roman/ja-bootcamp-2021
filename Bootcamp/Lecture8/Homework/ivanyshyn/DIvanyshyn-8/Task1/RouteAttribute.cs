using System;

namespace DIvanyshyn_8.AssembliesExample
{
    [System.AttributeUsage(System.AttributeTargets.Method | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class RouteAttribute : Attribute
    {
        // This is a name argument
        public RouteAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; init; }
    }
}