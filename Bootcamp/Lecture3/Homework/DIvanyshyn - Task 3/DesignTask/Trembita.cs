using System;

namespace DIvanyshyn___Task_3
{
    public class Trembita : MusicInstrument
    {
        public int Lenght { get; set; }
        public Trembita() : this(0) { }
        public Trembita(int loudness) : base(loudness) { }

        public override string InstrumentName => "Trembita";

        public override void Play()
        {
            Console.WriteLine("Take a deeep deeep breath..");
            base.Play();
        }

        public override void Pause()
        {
            Console.WriteLine("Hooh, all my listeners are gone? Nevermind");
            base.Pause();
        }

        public override void Stop()
        {
            Console.WriteLine("*dies without air*");
        }
    }
}