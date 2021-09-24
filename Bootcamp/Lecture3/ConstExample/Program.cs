using System;

namespace ConstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MathClass.PI);
            // Error! Can't change a constant!
            // MyMathClass.PI = 3.1444;

            Console.WriteLine("The value of PI is: {0}", MathClass2.PI);
            
            Console.ReadLine();
        }
    }
}
