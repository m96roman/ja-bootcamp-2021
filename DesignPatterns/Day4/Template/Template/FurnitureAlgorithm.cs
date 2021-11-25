namespace Template
{
    class FurnitureAlgorithm : BasicHumanShoppingAlgorithm
    {
        protected override void ArriveToDestination(string product)
        {
            System.Console.WriteLine("Leave home");
            System.Console.WriteLine("Arrive to shop");
        }

        protected override void Buy(string product)
        {
            System.Console.WriteLine("Write check");
            System.Console.WriteLine("Use service");
        }
    }
}