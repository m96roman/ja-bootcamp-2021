using ConsoleApp6.Interfaces;

namespace ConsoleApp6
{
    public class Expert
    {
        public IDecorate Decor { private get; set; }

        public Expert(IDecorate decor)
        {
            Decor = decor;
        }

        public void Decorate()
        {
            Decor.Decorate();
        }
    }
}
