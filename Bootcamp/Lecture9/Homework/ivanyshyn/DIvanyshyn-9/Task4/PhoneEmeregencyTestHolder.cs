using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_9.HereWeGoAgain
{
    /// <summary>
    ///  - It can hold any number of phones
    ///- It also should be possible to use this type in foreach loop
    /// </summary>
    internal class PhoneEmeregencyTestHolder : IEnumerable<Phone>
    {
        private List<Phone> phones;

        public PhoneEmeregencyTestHolder()
        {
            phones = new List<Phone>();
        }

        public PhoneEmeregencyTestHolder(IEnumerable<Phone> phones) : base()
        {
            this.phones.AddRange(phones.ToList());
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
        /// <exception cref="BatteryIsDeadException">Rethrows from <see cref="Nokia"/></exception>
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
                        string message = $"Phone failed to call an ambulance: {bs.Phone.GetType().Name}";

                        Console.WriteLine(message);
                        Logger.GetIntance.WriteLine(message, MessageType.Warning);
                        throw;
                    }

                    Console.WriteLine(new string('[', 20));
                    nokia.PrayForBattery();
                    nokia.CallForAmbulance();
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
