using System;

namespace Task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((number % 3 == 0 || number % 7 == 0 ? true : false).ToString());
        }
    }
}
