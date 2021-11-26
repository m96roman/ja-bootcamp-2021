using Models;

namespace Diller_Builder.Config
{
    public class A2Distributor : DistributorBase
    {
        public A2Distributor() : base(new A2CarModel()) { }

        public override void Reset()
        {
            carModel = new A2CarModel();
        }
    }
}