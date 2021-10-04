using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask6
{
    public static class ExtensionMethod
    {
        public static ICollection<T> Filter<T>(this ICollection<T> collection, Func<T, bool> filterText) => collection.Where(filterText).ToList();

        public static ICollection<V> Map<T, V>(this ICollection<T> collection, Func<T, V> filterText) => collection.Select(source => filterText(source)).ToArray();
    }
}