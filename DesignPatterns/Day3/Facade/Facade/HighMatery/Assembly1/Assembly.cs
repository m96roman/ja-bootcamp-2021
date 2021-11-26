using HighMatery;

namespace Facade.HightMatery.Assemblies1
{
    class Assembly : IAssembly
    {
        public Library[] BuildAssembly(bool canBuild)
        {
            if (canBuild)
            {
                System.Console.WriteLine("happy copy noices");

                return new Library[100];
            }

            System.Console.WriteLine("You made a mistacke, a great one");

            return new Library[0];
        }
    }
}
