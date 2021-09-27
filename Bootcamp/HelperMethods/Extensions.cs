using System;
using System.Collections.Generic;
using System.Text;

namespace HelperMethods
{
    public static class Extensions
    {
        /// <summary>
        /// Swaps chars with specified indexes
        /// </summary>
        /// <param name="var">string char of which need to be swapped</param>
        /// <param name="index1">index of first element</param>
        /// <param name="index2">index of secound element</param>
        /// <returns>New string with swapped chars</returns>
        /// <exception cref="IndexOutOfRangeException">If indexes are out range</exception>
        /// 
        public static string swap(this string var, int index1, int index2)
        {

            StringBuilder sb = new StringBuilder(var);

            char swapval = sb[index1];
            sb[index1] = sb[index2];
            sb[index2] = swapval;
            return sb.ToString();
        }
        public static string ToUpper(this string var, int lenght)
        {
            if (var.Length < lenght)
                return var;
            var sub = var.Substring(0, lenght);
            return var.Replace(sub, sub.ToUpper());

        }
    }
}
