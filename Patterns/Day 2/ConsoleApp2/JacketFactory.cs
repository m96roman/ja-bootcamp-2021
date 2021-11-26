namespace ConsoleApp2
{
    public abstract class JacketFactory
    {
        public abstract JacketPart CreateBack();
        public abstract JacketPart CreateBefore();
        public abstract JacketPart CreateCollar();
        public abstract JacketPart CreateHood();
        public abstract JacketPart CreateSleeve();
    }
}
