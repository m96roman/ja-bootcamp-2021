using System;

namespace Task10
{
    class Task10
    {
        static void Main(string[] args)
        {
            int countOfNumbers = 10;
            int[] inputValue = new int[countOfNumbers];
            int sumOfNumber = default;
            double average = default;
            for (int i = 0; i < countOfNumbers; i++)
            {
                inputValue[i] = int.Parse(Console.ReadLine());
                sumOfNumber += inputValue[i];
            }

            average = (double)sumOfNumber / countOfNumbers;
            Console.WriteLine($"Sum of number : {sumOfNumber.ToString()}\nAverage of number : {average.ToString()}");
        }
    }
}
