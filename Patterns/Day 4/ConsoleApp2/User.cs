using System;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class User : IObserver
    {
        IObservable vodokanal;

        private string Name { get; set; }

        public User(string name, IObservable obs)
        {
            Name = name;
            vodokanal = obs;
            vodokanal.SubscribeObserver(this);
        }

        public void Update()
        {
            Console.WriteLine($"User {Name} was notified!");
        }

        public void UnSubscribe()
        {
            vodokanal.RemoveObserver(this);
            vodokanal = null;

            Console.WriteLine($"User {Name} stoped tracking");
        }
    }
}
