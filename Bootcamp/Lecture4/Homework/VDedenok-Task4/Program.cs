using System;
using System.Collections;

namespace VDedenok_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia1 = new Nokia()
            {
                BatteryLevel = 99
            };
           
            Nokia nokia2 = new Nokia()
            {
                BatteryLevel = 10
            };
          
            Phone iPhone10 = new IPhone()
            {
                BatteryLevel = 12
            };
          
            Phone iPhone13 = new IPhone()
            {
                BatteryLevel = 1
            };

            Phone[] phoneEmergencyTestHolder = new Phone[] { nokia1, nokia2, iPhone10, iPhone13 };
        
            TestEmergency(phoneEmergencyTestHolder);               
        }

        public static void TestEmergency(Array pray)
        {
            foreach (Phone p in pray)  
            {
                try
                {
                    p.CallAmbulance();
                    if (p is Nokia nokia)
                    {
                        nokia.PrayForBattery();
                    }
                }
                catch (BatteryIsDeadException ex)
                {
                    Console.WriteLine(ex.ShowMessage);
                    continue;
                }
                catch (PhoneOverflowException ex)
                {
                    Console.WriteLine(ex.ShowMessage);
                    continue;
                }
                p.ChargeABit();
            }
        }
        
    }
}




