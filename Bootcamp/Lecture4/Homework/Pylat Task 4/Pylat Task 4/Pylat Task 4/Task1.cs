using System;
using System.Collections.Generic;
using System.Text;

namespace Pylat_Task_4
{

    class Task1
        {
        static void TestEmergency(PhoneEmergencyTestHolder phoneEmergency)
        {
            foreach (var i in phoneEmergency)
            {
                try
                {
                    //i.CallAmbulance();
                }catch (PhoneExceptions ex)
                {
                    Console.WriteLine("");
                }
            }
        }

        public static void DoTask1()
            {
           // IPhone13 iphone = new IPhone13("Iphone13",4);
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


        }  } 

