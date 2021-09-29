using System;

namespace DIvanyshyn___Task_3
{
    public abstract class MusicInstrument : IPlayable, IDisposable
    {
        public abstract string InstrumentName { get; }
        private readonly int loudness;

        protected MusicInstrument(int loudness)
        {
            this.loudness = loudness;
        }

        public void Dispose()
        {
            DestroyInstrument();
        }

        public virtual void Pause()
        {
            Console.WriteLine("Starting pausing " + InstrumentName);
        }

        public virtual void Play()
        {
            Console.WriteLine("Starting playing " + InstrumentName + " with loudness " + loudness);
        }

        private void DestroyInstrument()
        {
            Console.WriteLine($"Throwing {InstrumentName} into garbage");
        }

        public static void DoPlay(MusicInstrument musicInstrument)
        {
            musicInstrument.Play();
            musicInstrument.Pause();
            musicInstrument.Stop();
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping playing " + InstrumentName);
        }
    }
}