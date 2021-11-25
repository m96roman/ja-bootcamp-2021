namespace Task1_FactoryMethod
{
    class Ship : ITransport
    {
        public string Deliver(string address, string goods)
        {
            return $"Goods: {goods} has been shipped by Cargo Ship to {address}";
        }
    }
}
