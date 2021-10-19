using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of strings to store in the array : ");
            int amountStrings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {amountStrings} strings for the array :");

            string[] arr = new string[amountStrings];

            for(int i=0; i<amountStrings; i++)
            {
                Console.Write($"Element[{i}] : ");
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine("First way: ");
            Console.WriteLine(String.Join(", ", arr));

            string prob = ", ";
            Console.WriteLine("Second way: ");
            Console.WriteLine(arr.Aggregate((i, j) => i + prob + j));
        }
    }
}
