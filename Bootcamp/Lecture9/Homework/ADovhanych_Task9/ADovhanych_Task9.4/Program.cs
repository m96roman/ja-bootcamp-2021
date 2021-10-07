﻿using System;

namespace ADovhanych_Task9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[]
            {
                new Nokia(4),
                new Nokia(8),
                new IPhone(25),
                new IPhone(10),
                new IPhone(3)
            };
            
            PhoneEmergencyTestHolder phoneEmergency = new PhoneEmergencyTestHolder(phones);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(phoneEmergency);
                }
                catch (BatteryIsDeadException ex)
                {
                    Logger logger = new();
                    logger.WriteLine(ex.ToString());
                    throw;
                }
            }
        }
    }
}
