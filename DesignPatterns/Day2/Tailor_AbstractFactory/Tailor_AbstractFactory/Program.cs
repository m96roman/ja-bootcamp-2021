using System;
using Tailor_AbstractFactory.Department_2;

namespace Tailor_AbstractFactory
{
    class Program
    {
        private static ITailorDepartment tailorDepartment { get; set; }

        static void Main(string[] args)
        {
            tailorDepartment = new Department1();

            Execute(tailorDepartment);
            Execute(tailorDepartment);

            tailorDepartment = new Department2();

            Execute(tailorDepartment);
            Execute(tailorDepartment);
            Execute(tailorDepartment);
            Execute(tailorDepartment);
            Execute(tailorDepartment);

            tailorDepartment = new Department3();

            Execute(tailorDepartment);
            Execute(tailorDepartment);
            Execute(tailorDepartment);
        }

        static void Execute(ITailorDepartment tailorDepartment)
        {
            Console.WriteLine(tailorDepartment.SewBack().GetType());
            Console.WriteLine(tailorDepartment.SewFront().GetType());
            Console.WriteLine(tailorDepartment.SewRight().GetType());
            Console.WriteLine(tailorDepartment.SewLeft().GetType());
            Console.WriteLine();
        }
    }
}
