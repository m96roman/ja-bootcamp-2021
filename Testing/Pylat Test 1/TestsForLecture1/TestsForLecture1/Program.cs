using Pylat_Task_4;
using System;
using System.Collections.Generic;

namespace TestsForLecture1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Is batery created?
            try
            {
                BateryLevelTests created = new BateryLevelTests("Is", 134);
                created.IsBateryLevelCreated();
            }
            catch
            {
                BateryLevelTests created = new BateryLevelTests("Is", 134);
                Logger logger = new Logger();
                logger.AddToListAndPrint("Batary level is not created");
                Console.WriteLine("-------------------");
                created.IsBateryLevelCreated();
            }

            // is batary higner than 5?
            try
            {
                BateryLevelTests created = new BateryLevelTests("Is", 134);
                created.IsBateryLevelHigher5();
            }
            catch
            {
                BateryLevelTests created = new BateryLevelTests("Is", 19);
                Logger logger = new Logger();
                logger.AddToListAndPrint("Batary level is 0");
                Console.WriteLine("-------------------");
                created.IsBateryLevelHigher5();
            }

            // charging to 100
            try
            {
                BateryLevelTests created = new BateryLevelTests("Is", 134);
                created.Charge();
                created.ChargeTo100();
            }
            catch
            {
                BateryLevelTests created = new BateryLevelTests("Is", 134);
                Logger logger = new Logger();
                logger.AddToListAndPrint("Batary level is not 100");
                Console.WriteLine("-------------------");
                created.ChargeTo100();
            }

            // is batary charged a bit?
            try
            {
                BateryLevelTests created = new BateryLevelTests("Is", 98);
                created.IsChargedABit();


            }
            catch
            {
                BateryLevelTests created = new BateryLevelTests("Is", 55);
                Logger logger = new Logger();
                logger.AddToListAndPrint("Batary level is not 100");
                Console.WriteLine("-------------------");
                created.ChargeTo100();
            }

            // Is batary lower than 5?
            try
            {
                BateryLevelTests created = new BateryLevelTests("Is", 4);
                created.IsBateryDad();
            }
            catch
            {
                BateryLevelTests created = new BateryLevelTests("Is", 4);
                Logger logger = new Logger();
                logger.AddToListAndPrint("Batary level lower than 5");
                Console.WriteLine("-------------------");    
            }
        }

        public class BateryLevelTests : PhoneBase
        {
            public BateryLevelTests(string typeOfPhone, int bateryLevel) : base(typeOfPhone, bateryLevel)
            { }

            public void IsBateryLevelCreated()
            {
                if (BateryLevel != null && BateryLevel >= 0 && BateryLevel <= 100)
                {
                    Console.WriteLine("Batary Level Is Created");
                    Console.WriteLine($"-----------------------------------");
                    Console.WriteLine($"Batary Level Is {BateryLevel}");
                }
                else
                {
                    Console.WriteLine("\nBatery is not created or wrong value");
                    Console.WriteLine($"Wrong batery level is {BateryLevel}\n");
                    Console.WriteLine($"-----------------------------------\n");
                }
            }

            public void IsBateryLevelHigher5()
            {
                if (BateryLevel <= 5)
                {
                    Console.WriteLine("Batery level is lower (between 0 and 5)");
                    Console.WriteLine($"-----------------------------------\n");
                }
                else
                {
                    Console.WriteLine("Batery is higher than 5\n");
                    Console.WriteLine($"-----------------------------------\n");
                }
            }

            public void ChargeTo100()
            {
                if (BateryLevel == 100)
                {
                    Console.WriteLine($"Batery level is {BateryLevel}");
                    Console.WriteLine($"-----------------------------------\n");
                }
                else
                {
                    Console.WriteLine("Batery is not 100");
                    Console.WriteLine($"-----------------------------------\n");
                }
            }
            public void IsChargedABit()
            {
                if (BateryLevel < 100)
                {
                    var batary = BateryLevel;
                    batary += 1;
                    ChargeABit();
                    if (BateryLevel == batary)
                    {
                        Console.WriteLine($"Batary is charged a bit = ({BateryLevel})");
                    }
                }
                else
                {
                    Console.WriteLine("Batery is 100");
                    Console.WriteLine($"-----------------------------------\n");
                }
            }

            public void IsBateryDad()
            {
                if (BateryLevel >= 5)
                {
                    Console.WriteLine("Batery higher than 4");
                    Console.WriteLine($"-----------------------------------\n");
                }
                else
                {          
                    BatteryIsDeadException();
                }
            }

        }
    }
}

