namespace ConsoleApp2
{
    public class Jacket
    {
        private JacketPart back;
        private JacketPart before;
        private JacketPart collar;
        private JacketPart hood;
        private JacketPart sleeve;

        public Jacket(JacketFactory factory)
        {
            back = factory.CreateBack();
            before = factory.CreateBefore();
            collar = factory.CreateCollar();
            hood = factory.CreateHood();
            sleeve = factory.CreateSleeve();
        }

        public void SewJacket()
        {
            back.Sew();
            before.Sew();
            sleeve.Sew();
            collar.Sew();
            hood.Sew();
        }
    }
}
