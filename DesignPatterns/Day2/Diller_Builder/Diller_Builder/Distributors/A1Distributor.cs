using Models;

namespace Diller_Builder.Config
{
    public class A1Distributor : DistributorBase
    {
        public A1Distributor() : base(new A1CarModel()) { }

        public override void Reset()
        {
            carModel = new A1CarModel();
        }
    }
}