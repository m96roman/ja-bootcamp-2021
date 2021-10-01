﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Task.Interfaces;
using Task.Exceptions;

namespace Task
{
    public class PhoneEmergencyTestHolder : IEnumerable
    {
        public IPhone[] Phones { get; set; }

        public PhoneEmergencyTestHolder(IPhone[] phonesForTest)
        {
            Phones = phonesForTest;
        }

        public static void TestEmergency(PhoneEmergencyTestHolder holder)
        {
            foreach (IPhone phone in holder)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    Console.WriteLine($"Phone failed to call an ambulance: Phone name -> {phone.PhoneName}, Phone Type -> {phone.Type}");
                    if (ex.Phone is Nokia nokia)
                    {
                        nokia.PrayForBattery();
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    phone.ChargeABit();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => Phones.GetEnumerator();
    }
}
