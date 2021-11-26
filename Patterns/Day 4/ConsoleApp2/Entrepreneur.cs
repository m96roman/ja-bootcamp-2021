using System;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class Entrepreneur : IObserver
    {
        IObservable vodokanal;

        private string Name { get; set; }

        public Entrepreneur(string name, IObservable obs)
        {
            Name = name;
            vodokanal = obs;
            vodokanal.SubscribeObserver(this);
        }

        public void Update()
        {
            Console.WriteLine($"Entrepreneur {Name} was notified!");
        }

        public void UnSubscribe()
        {
            vodokanal.RemoveObserver(this);
            vodokanal = null;

            Console.WriteLine($"Entrepreneur {Name} stoped tracking");
        }
    }
}
