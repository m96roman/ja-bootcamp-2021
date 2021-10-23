using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIVanyshyn_Task4
{
    /// <summary>
    /// - It can hold any number of phones
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
        /// <exception cref="ArgumentNullException">When <paramref name="phone"/> is null</exception>
        public void Add(Phone phone)
        {
            if (phone is null)
            {
                throw new ArgumentNullException(nameof(phone));
            }

            phones.Add(phone);
        }

        /// <summary>
        /// Removes the specific phone from collection
        /// </summary>
        /// <param name="phone">The phone to add</param>
        /// <exception cref="ArgumentNullException">When <paramref name="phone"/> is null</exception>
        public void Remove(Phone phone)
        {
            if (phone is null)
            {
                throw new ArgumentNullException(nameof(phone));
            }

            phones.Remove(phone);
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
                CallAmbulanceRoutine(item);
            }
        }

        /// <summary>
        /// CallAmbulence to <paramref name="item"/> 
        /// if <see cref="BatteryIsDeadException"/> is thrown then goes to catch block
        /// and perform action in 
        /// </summary>
        /// <param name="item">the Phone item that need to be routined</param>
        private static void CallAmbulanceRoutine(Phone item)
        {
            try
            {
                item.CallForAmbulance();
            }
            catch (BatteryIsDeadException bs)
            {
                if (bs.Phone is Nokia nokia)
                {
                    PrayForNokia(nokia);

                    return;
                }

                LogCallAnAmbulanceError(bs.Phone);

                throw;
            }
            finally
            {
                item.ChargeABit();
            }
        }

        /// <summary>
        /// Logs CllAnAmbulance error
        /// </summary>
        /// <param name="phone"></param>
        private static void LogCallAnAmbulanceError(Phone phone)
        {
            string message = $"Phone failed to call an ambulance: {phone.GetType().Name}";
            phone.logger.WriteLine(message, MessageType.Exception);
        }

        /// <summary>
        /// Call from <paramref name="nokia"/> method PrayForBattery and CallForAmbulance
        /// </summary>
        /// <param name="nokia">Phone parameter</param>
        private static void PrayForNokia(Nokia nokia)
        {
            nokia.PrayForBattery();
            nokia.CallForAmbulance();
        }
    }
}
