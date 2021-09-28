using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input upto the table number starting from 1 : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication table from 1 to " + number);

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (j <= number - 1)
                        Console.Write("{0} * {1} = {2}, ", i, j, i * j);
                }
                Console.Write("\n");
            }
        }
    }
}
