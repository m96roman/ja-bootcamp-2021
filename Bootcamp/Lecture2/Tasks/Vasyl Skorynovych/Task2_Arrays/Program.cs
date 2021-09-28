﻿using System;

namespace Task2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] values = new int[n];

            Console.WriteLine($"Input {n} number of elements in the array : ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} - ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(values[i] + " ");
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (values[i] == values[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine($"Total number of duplicate elements found in the array is: {count}");
        }
    }
}
