using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DIvanyshyn_8.AssembliesExample
{
    /// <summary>
    /// Gets all types derivied from specific type
    /// </summary>
    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable GetEnumerableOfType(Type T)
        {
            ArrayList objects = new ArrayList();
            foreach (Type type in
                Assembly.GetAssembly(T).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(T)))
            {
                objects.Add(Activator.CreateInstance(type));
            }

            return objects;
        }
    }
}