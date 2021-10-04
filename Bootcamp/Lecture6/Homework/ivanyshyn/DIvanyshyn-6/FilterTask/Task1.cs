namespace DIvanyshyn_6.FilterTask
{
    internal class Task1
    {
        /// <summary>
        /// * Write extension method "Filter" for type ICollection<string>, which
        /// accepts filter function as an argument and returns collection of items which
        ///match filter criteria.
        ///    * Write extension method "Map" for type ICollection<string>, which
        ///accepts map function, that transforms string to int. Result should be ICollection<int>
        ///* Create collection of strings.
        ///  Call "Filter" method (to filter elements which start from uppercase)
        /// Then call "Map" function to get those elements length
        ///** Make Filter/Map as generic methods.Add own example of usage.
        /// </summary>
        internal static void Execute()
        {
            var arr = new[] { "This", "example", "string", "is", "not", "so", "cool", "(" };
            System.Console.WriteLine(arr.ConvertToString(separator: " "));

            var filtered = arr.Filter(x => !char.IsUpper(x[0]));

            System.Console.WriteLine(filtered.ConvertToString(separator: " "));

            System.Console.WriteLine(filtered.Map(s => s.Length).ConvertToString(separator: " "));
        }
    }
}