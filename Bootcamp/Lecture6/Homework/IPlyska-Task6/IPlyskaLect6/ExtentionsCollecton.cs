using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect6
{
    
    public static class ExtentionsCollecton
    {
        public static ICollection<string> Filter(this ICollection<string> container, Func<string, bool> func )
        {
            if (container is null || container.Count == 0)
            {
                return null;
            }

            var result = new List<string>();

            foreach (var item in container)
            {
                if ((func?.Invoke(item)).HasValue && (func?.Invoke(item)).Value)
                {
                    result.Add(item);
                }  
            }

            return result;
            //return container.Select(x => x.Trim()).Where(x => char.IsUpper(x.First())).ToList();
        }

        public static ICollection<int> Map(this ICollection<string> mapper, Func<string, int> func)
        {
            if (mapper is null || mapper.Count == 0)
            {
                return null;
            }

            var result = new List<int>();

            foreach (var item in mapper)
            {
                result.Add((func?.Invoke(item)).Value);
            }

            return result;
            //return mapper.Where(x => !string.IsNullOrEmpty(x)).Select(x => Convert.ToInt32(x.Length)).ToList();
        }

        public static ICollection<T> Filter<T>(this ICollection<T> container, Func<T,T> action) where T : struct
        {
            if (container is null || container.Count == 0)
            {
                return null;
            }
           
           return container.Select(x => (action?.Invoke(x)).Value).ToList();
        }

        public static ICollection<T> Map<T>(this ICollection<T> mapper, Func<T, T> action) 
        {
            if (mapper is null || mapper.Count == 0)
            {
                return null;
            }

            return mapper.Select(x => (action.Invoke(x))).ToList();
        }
    }
}
