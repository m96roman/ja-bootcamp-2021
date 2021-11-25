namespace Task1_FactoryMethod
{
    class OverlandLogisticCompany : LogisticCompany
    {
        protected override ITransport DefineTransport()
        {
            return new Truck();
        }
    }
}
