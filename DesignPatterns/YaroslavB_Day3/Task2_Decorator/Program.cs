using System;

namespace Task2_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            IPC officePC = new OfficePC();
            IPC gamePC = new GamePC();
            IPC workPC = new WorkPC();

            IPC ledBackLightGame = new LEDBacklight(gamePC);
            IPC wifiAndLedGame = new WiFiCard(ledBackLightGame);

            Console.WriteLine("=========== Assembly Game PC with LED BackLight ===============");

            ledBackLightGame.AssembleSystemBlock();
            ledBackLightGame.SetMonitor();
            ledBackLightGame.SetAccessories();

            Console.WriteLine("\n\n=========== Assembly Game PC with LED BackLight and WiFi ===============");

            wifiAndLedGame.AssembleSystemBlock();
            wifiAndLedGame.SetAccessories();
            wifiAndLedGame.SetMonitor();

            Console.WriteLine("\n\n=========== Assembly Office PC with  WiFi ===============");

            IPC wifi = new WiFiCard(officePC);
            wifi.AssembleSystemBlock();
            wifi.SetAccessories();
            wifi.SetMonitor();


            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
