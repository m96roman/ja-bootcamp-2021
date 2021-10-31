using System;

namespace VDedenok_Task9
{
    class TestEmergency
    {
        public void CallTestEmergency(Phone[] tested)
        {
            Logger logger = new Logger();
           
            foreach (var phone in tested)
            {
                Console.WriteLine("------------------------------------------------");
                   
                try
                {
                    phone.CallAmbulance();

                    if (phone is Nokia nokia)
                    {
                        nokia.PrayForBattery();
                    }
                }
                catch (BatteryIsDeadException ex)
                {
                    Console.WriteLine($"Exception message: {ex.ShowMessage}");
                  
                    logger.WriteLine(ex.ShowMessage);
                    continue;
                }
                catch (PhoneOverflowException ex)
                {
                    Console.WriteLine($"Exception message: {ex.ShowMessage}");
                    continue;
                }
                finally
                {
                    phone.ChargeABit();
                }
            }
        }
    }
}
