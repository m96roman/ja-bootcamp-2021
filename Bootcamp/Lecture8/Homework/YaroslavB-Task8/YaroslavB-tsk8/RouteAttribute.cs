using System;

namespace YaroslavB_tsk8
{
    [AttributeUsage(AttributeTargets.Method)]
    class RouteAttribute : Attribute
    {
        public string Name { get; }

        public RouteAttribute(string name)
        {
            Name = name;
        }
    }
}
