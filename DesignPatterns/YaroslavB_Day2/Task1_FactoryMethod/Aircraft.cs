namespace Task1_FactoryMethod
{
    class Aircraft : ITransport
    {
        string ITransport.Deliver(string address, string goods)
        {
            return $"Goods: {goods} has been shipped by Cargo Plane to {address}";
        }
    }
}
