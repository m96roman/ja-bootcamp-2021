using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterInform waterInform = new WaterInform();
            ClientUsers users = new ClientUsers();
            waterInform.Add(users);

            BuisnessClients buisness = new BuisnessClients();
            waterInform.Add(buisness);

            waterInform.RandomOffWater();
            Console.WriteLine();
            waterInform.RandomOffWater();
            waterInform.RandomOffWater();
            waterInform.RandomOffWater();
            waterInform.RandomOffWater();
            waterInform.RandomOffWater();
            waterInform.RandomOffWater();
            waterInform.RandomOffWater();
        }
    }
}
