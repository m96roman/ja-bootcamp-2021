using System;

namespace Task1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] values = new int[n];

            Console.WriteLine($"Input {n} number of elements in the array : ");

            for(int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} - ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", values));

            Array.Reverse(values);

            Console.WriteLine(String.Join(" ", values));
        }
    }
}
