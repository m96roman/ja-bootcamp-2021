using System;

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
            Console.WriteLine(tailorDepartment.CreateClothes().GetType());
            Console.WriteLine();
        }
    }
}
