namespace DIvanyshyn___Task_3
{
    public class Guitar : MusicInstrument
    {
        public Guitar(int loudness) : base(loudness) { }

        public override void Play()
        {
            //Kuchma style
            System.Console.WriteLine("Два кольори мої, два кольори.. Еххх");
        }

        public override string InstrumentName => "Classic guitar";
    }
}