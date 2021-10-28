using System;
using System.Collections.Generic;
using System.Text;
using Pylat_Lecture_9___.Task4;

namespace Pylat_Task_4
{
    class Task1
    {
        Logger logger = new Logger();

         public void TesmEmergency(PhoneEmergencyTestHolder phoneEmergencyTestHolder)
        {
            var exe = new Exception("ddd");
            foreach (var phone in phoneEmergencyTestHolder)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Phone failed to call an ambulance: {phone.TypeOfPhone}");

                    if (phone is Nokia)
                    {
                        (phone as Nokia).PrayForBattery();
                        phone.CallAmbulance();
                    }
                    else
                    {
                        logger.LogExeptions(exe.ToString());
                    }
                }
                finally
                {
                    phone.ChargeABit();
                }
            }
        }

        public static void DoTask1()
        {
            //IPhone13 iphone = new IPhone13("Iphone13",4);
            //iphone.CheckingBateryLevel(); 
            //iphone.CallAmbulance();
            //iphone.BatteryIsDeadException();
            //iphone.Charge();

            // Nokia nokia = new Nokia("Nokia",120);
            //nokia.CheckingBateryLevel();
            //nokia.CallAmbulance();
            //nokia.BatteryIsDeadException();
            //nokia.PrayForBattery();
            //nokia.Charge();
        }
    }
}

