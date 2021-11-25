namespace Task3_Builder
{
    class BuilderModelA1 : IBuilder
    {
        private CarModelA1 _a1;
        public BuilderModelA1()
        {
            _a1 = new CarModelA1();
        }

        public CarModelA1 GetResult()
        {
            return _a1;
        }

        public void SetEngine(double engineVolume)
        {
            _a1.EngineVolume = engineVolume;
        }

        public void SetSeatsHeater(bool isNeeded)
        {
            _a1.SeatsHeater = isNeeded;
        }

        public void SetWheelDisks(int diameter)
        {
            _a1.WheelDisks = diameter;
        }
    }
}
