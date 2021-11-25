namespace Template
{
    internal class PresentsAlgorithm : BasicHumanShoppingAlgorithm
    {
        protected override void ArriveToDestination(string product)
        {
            System.Console.WriteLine("Leave home");
            System.Console.WriteLine("Arrive to shop mall");
        }

        protected override void Choose(string product)
        {
            System.Console.WriteLine($"Choose neded {product}");
        }
    }
}