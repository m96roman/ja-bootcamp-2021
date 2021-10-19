using Pylat_Task_4;
using System;

namespace TestsForLecture1
{
    partial class Program
    {
        public class BateryLevelTests : PhoneBase
        {
            public BateryLevelTests(string typeOfPhone, int bateryLevel) : base(typeOfPhone, bateryLevel)
            { }

            public void IsBateryLevelCreated()
            {
                if (BateryLevel != null && BateryLevel <= 5 && BateryLevel > 0)
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
                    var tesrBatery = 0;
                    CallAmbulance();
                    if(tesrBatery == BateryLevel)
                    {
                        Console.WriteLine("Test 2 passed");
                    }else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    Console.WriteLine("Test 2 passed");
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
                    throw new Exception("Batery is not 100");
                }
            }

            public void IsChargedABit()
            {
                var batary = BateryLevel;
                batary += 1;
                ChargeABit();
                if (BateryLevel == batary)
                {
                    Console.WriteLine($"Batary is charged a bit = ({BateryLevel})");
                } else
                {
                    throw new Exception();
                }
            }
            public void IsBateryDad()
            {
                if (BateryLevel < 5)
                {
                    BatteryIsDeadException();
                }
                else
                {
                    Console.WriteLine("Batery higher than 4");
                    Console.WriteLine($"-----------------------------------\n");
                    throw new Exception();
                }
            }
      
        }
    }
        }
    



