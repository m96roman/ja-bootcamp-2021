using ConsoleApp2.Parts;

namespace ConsoleApp2
{
    public class JacketFactoryC : JacketFactory
    {
        public override Back CreateBack()
        {
            return new Back();
        }

        public override Before CreateBefore()
        {
            return new Before();
        }

        public override Collar CreateCollar()
        {
            return new Collar();
        }

        public override Hood CreateHood()
        {
            return new Hood();
        }

        public override Sleeve CreateSleeve()
        {
            return new Sleeve();
        }
    }
}
