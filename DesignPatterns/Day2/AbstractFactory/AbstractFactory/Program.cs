using AbstractFactory.Departments;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var departmentA = new DepartmentFactoryA();
            var departmentB = new DepartmentFactoryB();
            var departmentC = new DepartmentFactoryC();

            departmentA.CreateModelA();
            departmentA.CreateModelA();

            for (int i = 0; i < 5; i++) 
            {
                departmentB.CreateModelB();
            }

            for (int i = 0; i < 3; i++)
            {
                departmentC.CreateModelC();
            }
        }
    }
}
