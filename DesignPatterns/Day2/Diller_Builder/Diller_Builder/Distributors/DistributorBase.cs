using Models;

namespace Diller_Builder.Config
{
    public abstract class DistributorBase : ICarDistributor
    {
        protected ICarModel carModel;

        protected DistributorBase(ICarModel carModel)
        {
            this.carModel = carModel;
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

        public abstract void Reset();
    }
}