using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIVanyshyn_Task4
{
    /// <summary>
    ///  - It can hold any number of phones
    ///- It also should be possible to use this type in foreach loop
    /// </summary>
    class PhoneEmeregencyTestHolder : IEnumerable<Phone>
    {
        private List<Phone> phones;

        public PhoneEmeregencyTestHolder(IEnumerable<Phone> phones)
        {
            this.phones = phones.ToList();
        }

        /// <summary>
        /// Adds phone to collection
        /// </summary>
        /// <param name="phone">A phone :)</param>
        public void Add(Phone phone)
        {
            phones.Add(phone);
        }

        public IEnumerator<Phone> GetEnumerator()
        {
            return phones.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)phones).GetEnumerator();
        }

        /// <summary>
        /// - when called it goes through every phone and trying to call an ambulance
        /// - When BatteryIsDeadException is thrown write that "Phone failed to call an ambulance: phoneType", exception is re-thrown.
        ///- when type of the Phone is Nokia than use PrayForBattery() method and call ambulance again, loop is not interrupted.
        /// - In the end to the method call ChargeABit() method on every phone in PhoneEmergencyTestHolder, even when exception was re-thrown.
        /// </summary>
        /// <param name="holder"><paramref name="holder"/> for operating</param>
        internal static void TestEmeregency(PhoneEmeregencyTestHolder holder)
        {
            foreach (var item in holder)
            {
                try
                {
                    item.CallForAmbulance();
                }
                catch (BatteryIsDeadException bs)
                {
                    if (bs.Phone is not Nokia nokia)
                    {
                        Console.WriteLine($"Phone failed to call an ambulance: {bs.Phone.GetType().Name}");
                        //It is not the same logic like return right?
                        throw;
                    }
                    Console.WriteLine(new string('[', 20));
                    nokia.PrayForBattery();
                    Console.WriteLine(new string(']', 20));
                }
                finally
                {
                    item.ChargeABit();
                }
            }
        }
    }
}
