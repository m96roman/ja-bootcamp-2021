using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            int countOfNumbers = 2;
            int[] inputValue = new int[countOfNumbers];

            for (int i = 0; i < countOfNumbers; i++)
            {

                inputValue[i] = int.Parse(Console.ReadLine());
            }

            if (inputValue[0].Equals(inputValue[1]))
            {
                Console.WriteLine((inputValue[0] * 3).ToString());
            }
            else {
              
                float result = (float)(inputValue[0] + inputValue[1]) / 8;
                Console.WriteLine(result.ToString());
            }
        }
    }
}
