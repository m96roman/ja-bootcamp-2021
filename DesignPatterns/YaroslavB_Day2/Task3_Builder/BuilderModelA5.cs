namespace Task3_Builder
{
    class BuilderModelA5 : IBuilder
    {
        private CarModelA5 _a5;
        public BuilderModelA5()
        {
            _a5 = new CarModelA5();
        }

        public CarModelA5 GetResult()
        {
            return _a5;
        }

        public void SetEngine(double engineVolume)
        {
            _a5.EngineVolume = engineVolume;
        }

        public void SetSeatsHeater(bool isNeeded)
        {
            _a5.SeatsHeater = isNeeded;
        }

        public void SetWheelDisks(int diameter)
        {
            _a5.WheelDisks = diameter;
        }
    }
}
