﻿using System;
using Task.Interfaces;
using Task.Exceptions;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhone[] phones = new IPhone[]
            {
                new Iphone13
                {
                    PhoneName = "IPhone 13 Test 1",
                    BatteryLevel = 4,
                    Type = PhoneTypes.IphoneType
                },
                new Iphone13
                {
                    PhoneName = "IPhone 13 Test 2",
                    BatteryLevel = 8,
                    Type = PhoneTypes.IphoneType
                },
                new Iphone13
                {
                    PhoneName = "IPhone 13 Test 3",
                    BatteryLevel = 25,
                    Type = PhoneTypes.IphoneType
                },
                new Nokia
                {
                    PhoneName = "Nokia 3110 Test 1",
                    BatteryLevel = 4,
                    Type = PhoneTypes.NokiaType
                },
                new Nokia
                {
                    PhoneName = "Nokia 3110 Test 2",
                    BatteryLevel = 8,
                    Type = PhoneTypes.NokiaType
                },
                new Nokia
                {
                    PhoneName = "Nokia 3110 Test 3",
                    BatteryLevel = 25,
                    Type = PhoneTypes.NokiaType
                },
            };

            PhoneEmergencyTestHolder tests = new PhoneEmergencyTestHolder(phones);

            for(int i = 0; i < 10; i++)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(tests);
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.Phone.Charge();
                }
            }
        }
    }
}
