using System;
using System.Collections;

namespace VDedenok_Task4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Nokia Nokia1 = new Nokia();
            Nokia Nokia2 = new Nokia();
            Nokia Nokia3 = new Nokia();
               
            Nokia1.ButteryLevel = 15;
            Nokia2.ButteryLevel = 10;
            Nokia3.ButteryLevel = 66;
            
            Phone IPhone7 = new IPhone();
            Phone IPhone10 = new IPhone();
            Phone IPhone13 = new IPhone();

            IPhone7.ButteryLevel = 55;
            IPhone10.ButteryLevel = 12;
            IPhone13.ButteryLevel = 84;

            Phone[] PhoneEmergencyTestHolder = new Phone[] { Nokia1, Nokia2, Nokia3, IPhone7, IPhone10, IPhone13 };

            static void TestEmergency(Array pray) {
                try
                {
                    foreach (Phone p in pray)
                    {
                        int level = p.ButteryLevel;
                        p.CallAmbulance(level);
                        if (p.GetType().Name == "Nokia")
                        {
                            Console.WriteLine("This method is called only for Nokia instead of PrayForNokia.");
                            p.ChargeABit(level);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            TestEmergency(PhoneEmergencyTestHolder);
        }

        //це не вдалося використати, але поки залишу тут
        class TestEmergency : IEnumerable
        {
            Phone [] PhoneEmergencyTestHolder = new Phone[]{};
            public IEnumerator GetEnumerator()
            {
                return PhoneEmergencyTestHolder.GetEnumerator();
            }
        }

        class Phone
        {
            private int butteryLevel;
                     
            public int ButteryLevel
            {
                get
                {                 
                        return butteryLevel;              
                }
                set
                {
                    if (value < 100 && value > 5)
                    {
                        butteryLevel = value;
                       // CallAmbulance(value);
                    }
                    else if (value < 5 && value > 0)
                    {
                        butteryLevel = 0;
                        throw new BatteryIsDeadException("This is battery Dead Exception message!", this)
                        {
                            ShowMessage = "Battery is dead!"
                        };
                    }
                    else
                    {
                        throw new PhoneOverflowException("Datas are unappopriate!")
                        {
                            ShowMessage = "This is some eceptional message."
                        };
                    }
                }             
             }

          public void CallAmbulance(int batteryLevel)
            {           
                {
                    if (batteryLevel > 5)
                    {
                        batteryLevel += 5;
                        Console.WriteLine($"calling an ambulance from {this.GetType().Name}, remaining charge: {batteryLevel}%");
                    }
                }
            }

            public void Charge(int batteryLevel)
            {
                batteryLevel += 1;
                Console.WriteLine($"Charging {this.GetType().Name} by 1 %");
            }
           
            public void ChargeABit(int batteryLevel)
            {
                batteryLevel = 100;
                Console.WriteLine($"Charging {this.GetType().Name} to 100%");
            }          

        }

        class Nokia:Phone 
        {
            /// не знала як зробити метод тільки для Нокіа, цей у циклі не змогла викликати
            public void PrayForBattery(int batteryLevel)
            {
                batteryLevel += 8;
                Console.WriteLine("praying for the battery");
            }
        }
      
        class IPhone : Phone { }

        class PhoneOverflowException : Exception
        {
            public String ShowMessage { get; set; }
            public PhoneOverflowException(string message)
            {
               
            }          
        }

        class BatteryIsDeadException : Exception
        {
            public Phone phoneInstance;
            public String ShowMessage { get; set; }
            public BatteryIsDeadException(string message, Phone phoneInstance)
            {
                this.phoneInstance = phoneInstance;
            }
        }

    }
}
    ///Помилки через try catch не могла зловити та застосувати IEnumerator теж не вдалося, відсилаю те що щробила.
    ///Я ще розберуся з цим




