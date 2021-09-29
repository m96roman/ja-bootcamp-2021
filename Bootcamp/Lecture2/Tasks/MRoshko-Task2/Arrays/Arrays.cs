using System;
using System.Collections.Generic;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Task1();
            // Task2();
        }

        static void Task2()
        {
            int[] inputArr = FillAnArray();
            var dict = new Dictionary<int, int>();

            foreach (var value in inputArr)
            {
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"Value {pair.Key} occurred {pair.Value} times.");
            }
        }

        static void Task1()
        {

            int[] inputArr = FillAnArray();

            Console.WriteLine("The values store into the array are:");
            PrintArray(in inputArr);
            Console.WriteLine("The values store into the array in reverse are :");
            Array.Reverse(inputArr);
            PrintArray(in inputArr);
        }

        static int[] FillAnArray()
        {
            Console.Write("Input the number of elements to store in the array :");
            int.TryParse(Console.ReadLine(), out int result);
            int arraySize = result;
            int[] array = new int[arraySize];
            Console.WriteLine($"Input {arraySize} number of elements in the array :");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"element - {i} : ");
                int.TryParse(Console.ReadLine(), out int numbers);
                array[i] = numbers;
            }

            return array;

        }

        static void PrintArray(in int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
            Console.Write("\n");
        }

    }
}
