using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task4
{
    public class PhoneEmergencyTestHolder : IEnumerable
    {
        private Phone[] phoneNumbers;

        public PhoneEmergencyTestHolder()
        {
        }

        public PhoneEmergencyTestHolder(Phone[] pArray)
        {
            phoneNumbers = new Phone[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                phoneNumbers[i] = pArray[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Phone phone in phoneNumbers)
            {
                yield return phone;
            }
        }
    }

}
