namespace Task1_FactoryMethod
{
    class SeaLogisticCompany : LogisticCompany
    {
        protected override ITransport DefineTransport()
        {
            return new Ship();
        }
    }
}
