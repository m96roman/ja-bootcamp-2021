using System;
using System.Collections;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 8, 6, 5 };

            var sqrNo = numbers.Select(number => new { Number = number, SqrNo = Math.Pow(number, 2) });

            //var sqrNo = from int number in numbers
            //            let sq = number * number
            //            select new { Number = number, SqrNo = sq };

            foreach (var item in sqrNo)
            {
                Console.WriteLine($"Number = {item.Number}, SqrNo = {item.SqrNo}");
            }
        }
    }
}
