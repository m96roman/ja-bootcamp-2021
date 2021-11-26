using Models;

namespace Diller_Builder.Config
{
    internal interface ICarDistributor
    {
        void BuidEngine(double engineCapacity);
        void BuildHeater(bool hasHeater);
        void BuidDisks(int discksDiameter);
        void Reset();
        ICarModel GetModel();
    }
}