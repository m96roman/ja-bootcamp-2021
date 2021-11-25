using System;

namespace Task2_AbstractFactory
{
    class Program
    {
        //ISewDepartment - Abstract Factory
        //SewDepartmentModelA, SewDepartmentModelB, SewDepartmentModelC - Concrete Factories
        //ISleeves, IHood, ICollar, IBack, IFront - Abstract Product
        //classes: Sleeves_*, Hood_*, Collar_*, Back_*, Front_*  - Concrete Products
        //FinalSewStage - client

        static void Main(string[] args)
        {
            Console.WriteLine("Sew 2 pcs. of model A:\n");
            var modelA = new FinalSewStage(new SewDepartmentModelA());

            Console.WriteLine(modelA.CreateFinalProduct());
            Console.WriteLine(modelA.CreateFinalProduct());


            Console.WriteLine("\n\nSew 5 pcs. of model B:\n");
            var modelB = new FinalSewStage(new SewDepartmentModelB());

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(modelB.CreateFinalProduct());
            }


            Console.WriteLine("\n\nSew 3 pcs. of model C:\n");
            var modelC = new FinalSewStage(new SewDepartmentModelC());

            Console.WriteLine(modelC.CreateFinalProduct());
            Console.WriteLine(modelC.CreateFinalProduct());
            Console.WriteLine(modelC.CreateFinalProduct());

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}



