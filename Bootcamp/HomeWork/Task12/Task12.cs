using System;

namespace Task12
{
    class Task12
    {
        static void Main(string[] args)
        {
            int countOfNumbers = 2;
            int[] inputValue = new int[countOfNumbers];

            for (int i = 0; i < countOfNumbers; i++)
            {
                try{
                    inputValue[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception) {
                    Console.WriteLine("Error");
                    return;
                }
               
               
            }

            Console.WriteLine($"Output : {DivisibleNumberInRange(inputValue).ToString()}");

        }
        static int DivisibleNumberInRange(int [] arr) {
            Array.Sort(arr);
            int countOfDivisible = default;
            for (int i = arr[0];i<arr[1];i++) {
                if (i%8 ==0) {
                    countOfDivisible++;
                }
            }
            return countOfDivisible;
        }
    
    }
}
