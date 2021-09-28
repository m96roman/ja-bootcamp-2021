using System;
using System.Collections;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            int countOfNumbers = 3;
            int[] inputValue = new int[countOfNumbers];

            for (int i = 0; i < countOfNumbers; i++)
            {

                inputValue[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(inputValue);

            Console.WriteLine($"Largest value = {inputValue[inputValue.Length-1].ToString()}\nLowest value = {inputValue[0].ToString()}");

        }
    }
}
