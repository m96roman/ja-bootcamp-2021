using ConsoleApp2.Parts;

namespace ConsoleApp2
{
    public abstract class JacketFactory
    {
        public abstract Back CreateBack();
        public abstract Before CreateBefore();
        public abstract Collar CreateCollar();
        public abstract Hood CreateHood();
        public abstract Sleeve CreateSleeve();
    }
}
