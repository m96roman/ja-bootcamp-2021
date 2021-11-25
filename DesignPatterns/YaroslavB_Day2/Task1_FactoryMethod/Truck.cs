namespace Task1_FactoryMethod
{
    class Truck : ITransport
    {
        string ITransport.Deliver(string address, string goods)
        {
            return $"Goods: {goods} has been shipped by Truck to {address}";
        }
    }
}
