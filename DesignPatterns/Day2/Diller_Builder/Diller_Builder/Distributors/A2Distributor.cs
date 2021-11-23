using Models;

namespace Diller_Builder.Config
{
    public class A2Distributor : ICarDistributor
    {
        private ICarModel carModel;

        public A2Distributor()
        {
            carModel = new A2CarModel();
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
            carModel = new A2CarModel();
        }
    }
}