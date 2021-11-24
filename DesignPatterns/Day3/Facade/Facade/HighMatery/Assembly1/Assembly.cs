namespace Facade.HightMatery.Assemblies1
{
    class Assembly : IAssembly
    {
        public void BuildAssembly(bool canBuild)
        {
            if (canBuild)
            {
                System.Console.WriteLine("happy copy noices");

                return;
            }

            System.Console.WriteLine("You made a mistacke, a great one");
        }
    }
}
