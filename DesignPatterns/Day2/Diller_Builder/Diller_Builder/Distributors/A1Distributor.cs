using Models;

namespace Diller_Builder.Config
{
    public class A1Distributor : ICarDistributor
    {
        private ICarModel carModel;

        public A1Distributor()
        {
            carModel = new A1CarModel();
        }

        public void BuidDisks(int discksDiameter)
        {
            carModel.DiskDiameter = discksDiameter;
        }

        public void BuidEngine(double engineCapacity)
        {
            carModel.EngineCapacity = engineCapacity;
        }

        public void BuildHeater(bool hasHeater)
        {
            carModel.HasHeater = hasHeater;
        }

        public ICarModel GetModel()
        {
            return carModel;
        }

        public void Reset()
        {
            carModel = new A1CarModel();
        }
    }
}