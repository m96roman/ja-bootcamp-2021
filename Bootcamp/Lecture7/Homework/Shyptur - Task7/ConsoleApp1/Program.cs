using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Task 1===========");
            Task1 task1 = new Task1();
            task1.task1();


            Console.WriteLine("==========Task 2===========");
            Task2 task2 = new Task2();
            task2.task2();

            Console.WriteLine("==========Task 3===========");
            Task3 task3 = new Task3();
            task3.task3();

            Console.WriteLine("==========Task 4===========");
            Task4 task4 = new Task4();
            task4.task4();
        }
    }
}
