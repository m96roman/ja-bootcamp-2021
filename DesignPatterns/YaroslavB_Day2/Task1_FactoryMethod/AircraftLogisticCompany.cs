namespace Task1_FactoryMethod
{
    class AircraftLogisticCompany : LogisticCompany
    {
        protected override ITransport DefineTransport()
        {
            return new Aircraft();
        }
    }
}
