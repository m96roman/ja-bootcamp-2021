using System;
using System.Collections.Generic;
using System.Linq;

namespace DIvanyshyn_6.FilterTask
{
    static class Extensions
    {
        /// <summary>
        /// Filters collection by <see cref="Func{T, TResult}"/> function
        /// return filtered collection or throws <see cref="ArgumentNullException"/> if func is not set
        /// </summary>
        /// <typeparam name="T">Type in collection</typeparam>
        /// <param name="collection"><see cref="ICollection{T}"/> of items</param>
        /// <param name="filter"><see cref="Func{T, TResult}"/> that filters collection </param>
        /// <exception cref="ArgumentNullException">When <paramref name="filter"/> is null</exception>
        /// <returns>new filtered <see cref="ICollection{T}"/></returns>
        public static ICollection<T> Filter<T>(this ICollection<T> collection, Func<T, bool> filter)
        {
            return collection.Where(filter).ToList();
        }

        /// <summary>
        /// Converts <see cref="IEnumerable{T}"/> to string with formated separator
        /// </summary>
        /// <typeparam name="T">Type of elements in <see cref="IEnumerable"/></typeparam>
        /// <param name="collection"> <see cref="IEnumerable{T}"/> that need to be converted</param>
        /// <param name="separator">Separator between elements</param>
        /// <exception cref="ArgumentNullException">When collection is null</exception>
        /// <returns>new string </returns>
        public static string ConvertToString<T>(this IEnumerable<T> collection, string separator = ",")
        {
            return String.Join(separator, collection);
        }

        /// <summary>
        /// Maps specified <paramref name="collection"/> to <see cref="ICollection{TDestination}"/>
        /// </summary>
        /// <typeparam name="TSource">Type of source collection</typeparam>
        /// <typeparam name="TDestination">Type in TDestination collection</typeparam>
        /// <param name="collection"></param>
        /// <param name="converter"></param>
        /// <exception cref="ArgumentNullException">If <paramref name="collection"/> of <paramref name="converter"/> is null </exception>
        /// <returns>new <see cref="ICollection{T}"/> with type <typeparamref name="TDestination"/></returns>
        public static ICollection<TDestination> Map<TSource, TDestination>(this ICollection<TSource> collection, Func<TSource, TDestination> converter)
        {
            return collection.Select(source => converter(source)).ToArray();
        }
    }
}