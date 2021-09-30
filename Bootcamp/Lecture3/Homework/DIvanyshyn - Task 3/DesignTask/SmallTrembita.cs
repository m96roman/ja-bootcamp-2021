namespace DIvanyshyn___Task_3
{
    public class SmallTrembita : Trembita
    {
        public override void Play()
        {
            System.Console.WriteLine("**takes small breath**");
            base.Play();
        }
    }
}