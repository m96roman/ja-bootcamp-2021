using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect6
{
    
    public static class ExtentionsCollecton
    {
        public static ICollection<string> Filter(this ICollection<string> container, Func<string, bool> func )
        {
            if (func is null)
            {
                throw new ArgumentException("Argument can not be null", nameof(func));
            }

            if (container is null || container.Count == 0)
            {
                return  new Collection<string>();
            }

            return container.Where(x => func(x)).ToList();
        }

        public static ICollection<int> Map(this ICollection<string> mapper, Func<string, int> func)
        {
            if (func is null)
            {
                throw new ArgumentException("Argument can not be null", nameof(func));
            }

            if (mapper is null || mapper.Count == 0)
            {
                return new Collection<int>();
            }

            return mapper.Select(x => func(x)).ToList();
        }

        public static ICollection<T> Filter<T>(this ICollection<T> container, Func<T, bool> action) 
        {
            if (action is null)
            {
                throw new ArgumentException("Argument can not be null", nameof(action));
            }

            if (container is null || container.Count == 0)
            {
                return new Collection<T>();
            }
           
           return container.Where(x => action(x)).ToList();
        }

        public static ICollection<T> Map<T>(this ICollection<T> mapper, Func<T, T> action) 
        {
            if (action is null)
            {
                throw new ArgumentException("Argument can not be null", nameof(action));
            }

            if (mapper is null || mapper.Count == 0)
            {
                return new Collection<T>();
            }

            return mapper.Select(x => action(x)).ToList();
        }
    }
}
