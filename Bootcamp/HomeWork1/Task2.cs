using System;

namespace HomeWork1
{
    class Task2
    {
        static void Main(string[] args)
        {
            int countOfNumbers = 3;
            int [] inputValue= new int[countOfNumbers];

            for (int i =0; i < countOfNumbers ;i++)
            {
                
                inputValue[i] = int.Parse(Console.ReadLine());
            }

            multiplication(inputValue);

        }

        static void multiplication(int [] arr ) {
            int length = arr.Length;
            int result = 1;
            for (int i = 0;i < length; i++) {
                result *= arr[i];
            }
            Console.WriteLine(result.ToString()) ;
        }
    }
}
