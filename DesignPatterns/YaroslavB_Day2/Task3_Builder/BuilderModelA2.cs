namespace Task3_Builder
{
    class BuilderModelA2 : IBuilder
    {
        private CarModelA2 _a2;
        public BuilderModelA2()
        {
            _a2 = new CarModelA2();
        }

        public CarModelA2 GetResult()
        {
            return _a2;
        }

        public void SetEngine(double engineVolume)
        {
            _a2.EngineVolume = engineVolume;
        }

        public void SetSeatsHeater(bool isNeeded)
        {
            _a2.SeatsHeater = isNeeded;
        }

        public void SetWheelDisks(int diameter)
        {
            _a2.WheelDisks = diameter;
        }
    }
}
