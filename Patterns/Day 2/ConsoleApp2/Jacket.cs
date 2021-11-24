using ConsoleApp2.Parts;

namespace ConsoleApp2
{
    public class Jacket
    {
        private Back back;
        private Before before;
        private Collar collar;
        private Hood hood;
        private Sleeve sleeve;

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
