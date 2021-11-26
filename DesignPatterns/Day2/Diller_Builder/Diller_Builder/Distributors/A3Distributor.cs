using Models;

namespace Diller_Builder.Config
{
    public class A3Distributor : DistributorBase
    {
        public A3Distributor() : base(new A3CarModel()) { }

        public override void Reset()
        {
            carModel = new A3CarModel();
        }
    }
}