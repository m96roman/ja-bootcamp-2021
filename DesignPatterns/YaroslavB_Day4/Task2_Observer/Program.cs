using System;

namespace Task2_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable vodokanal = new WaterProviderServise();

            ISubscriber ivan = new User("Ivan");
            ISubscriber taras = new Businessman("Taras");
            ISubscriber maxim = new UtilityService("CleanServise \'Maxim\'");        

            vodokanal.AddSubscriber(ivan);
            vodokanal.AddSubscriber(taras);
            vodokanal.AddSubscriber(maxim);

            vodokanal.NotifyObservers("Be aware - we are going to carry out maintenance for our pipelines.");
            (vodokanal as WaterProviderServise).CarryOutMaintenance();
            vodokanal.NotifyObservers("\nMaintenance is comleted.\n");

            vodokanal.RemoveSubscriber(maxim);

            vodokanal.NotifyObservers("Be aware - we are going to carry out maintenance for our pipelines.");
            (vodokanal as WaterProviderServise).CarryOutMaintenance();
            vodokanal.NotifyObservers("\nMaintenance is comleted.\n");

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
