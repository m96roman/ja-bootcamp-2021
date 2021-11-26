using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2

{   // Порушений принцип заміни барбари Лісков - ми маємо можливість створити обєкт який наслідує інтерфейс але не підтримує реалізацію всіх методів інтерфейсу,
    // з цього вже випливає інший порушений принцип -Interface segregation - треба розділити IDrivable на два
  
    class Program
    {
        static void Main(string[] args)
        {

                string marsLocation = "Mars";
                string sunLocation = "Sun";
                
                Console.WriteLine($"Lets navigate to {marsLocation}");
                AutoPilot autoPilot = new AutoPilot();
                autoPilot.Navigate(marsLocation, new Car());
                Console.WriteLine($"We are on {marsLocation} \r\n");

                Console.WriteLine($"Lets navigate to {sunLocation}");
                autoPilot = new AutoPilot();
                autoPilot.Navigate(sunLocation, new Train());
                Console.WriteLine($"We are on {sunLocation} \r\n");

            Console.ReadLine();
        }
    }
}
