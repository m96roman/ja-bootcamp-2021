using System;

namespace Task11
{
    class Task11
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1;i<= number ;i++) {
                for (int j = 1;j<=number;j++) {
                    Console.Write($"{i.ToString()}x{j.ToString()}={(i*j).ToString()} ");
                }
                Console.Write("\n");
            }
        }
    }
}
