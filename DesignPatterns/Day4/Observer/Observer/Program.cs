using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            UkrainianWaterWoodooMages ukrainianWaterWoodooMages = new UkrainianWaterWoodooMages();

            CommonFolk folk1 = new CommonFolk();
            EvilZhek evilZhek = new EvilZhek();

            evilZhek.AddClient(folk1);

            CommonFolk folk2 = new CommonFolk();

            ukrainianWaterWoodooMages.AddClient(evilZhek);
            ukrainianWaterWoodooMages.AddClient(folk2);

            ukrainianWaterWoodooMages.TurnOffEverything();

            ukrainianWaterWoodooMages.TurnOnEverything();

            evilZhek.TurnOffEverything();

            evilZhek.TurnOnEverything();

        }
    }
}
