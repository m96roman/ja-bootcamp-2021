using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testVariable = "Start";
            string nameOfTestVariable = nameof(testVariable);
            Console.WriteLine("Name of variable: " + nameOfTestVariable);
        }
    }
}
