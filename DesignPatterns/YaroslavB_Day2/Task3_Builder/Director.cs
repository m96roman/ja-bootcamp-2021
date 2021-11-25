namespace Task3_Builder
{
    class Director
    {
        private IBuilder _builder;
        public string Configuration { get; private set; }

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructBasicConfiguration()
        {
            Configuration = "Basic";
            _builder.SetEngine(1.5);
            _builder.SetWheelDisks(15);
            _builder.SetSeatsHeater(false);
        }

        public void ConstructPremiumConfiguration()
        {
            Configuration = "Premium";
            _builder.SetEngine(1.8);
            _builder.SetWheelDisks(16);
            _builder.SetSeatsHeater(false);
        }

        public void ConstructSuperMegaConfiguration()
        {
            Configuration = "SuperMega";
            _builder.SetEngine(1.81);
            _builder.SetWheelDisks(16);
            _builder.SetSeatsHeater(true);
        }
    }
}
