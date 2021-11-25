using System;

namespace Task2_Observed
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("John", new Vodokanal());
            Client client2 = new Client("Dmytro", new Vodokanal());

            Vodokanal vodokanal = new Vodokanal();

            vodokanal.RegisterObserver(client);
            vodokanal.RegisterObserver(client2);

            vodokanal.NotifyObserver();

            vodokanal.RemoveObserver(client2);

            vodokanal.NotifyObserver();
        }
    }
}
