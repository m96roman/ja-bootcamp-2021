using ConsoleApp2.PartsJacketB;

namespace ConsoleApp2
{
    public class JacketFactoryB : JacketFactory
    {
        public override JacketPart CreateBack()
        {
            return new Back() as JacketPart;
        }

        public override JacketPart CreateBefore()
        {
            return new Before() as JacketPart;
        }

        public override JacketPart CreateCollar()
        {
            return new Collar() as JacketPart;
        }

        public override JacketPart CreateHood()
        {
            return new Hood() as JacketPart;
        }

        public override JacketPart CreateSleeve()
        {
            return new Sleeve() as JacketPart;
        }
    }
}
