using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Observed
{
    class Client : IObserver
    {
        public string Name { get; set; }
        IObservable Vodokanal;

        public Client(string name, IObservable observable)
        {
            Name = name;
            Vodokanal = observable;
            Vodokanal.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            VodokanalInfo info = (VodokanalInfo)obj;

            if (info.Pressure < 20)
            {
                Console.WriteLine(@$"{Name} Pressure is low");
            }
            else
            {
                Console.WriteLine(@$"{Name} Pressure is good");
            }
        }

        public void Unsubscribe()
        {
            Vodokanal.RegisterObserver(this);
            Vodokanal = null;
        }
    }
}
