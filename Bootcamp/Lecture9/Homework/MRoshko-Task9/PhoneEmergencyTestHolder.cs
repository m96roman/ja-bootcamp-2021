using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task9
{
    public class PhoneEmergencyTestHolder : IEnumerable
    {
        private Phone[] phones;
        public PhoneEmergencyTestHolder()
        {
        }

        public PhoneEmergencyTestHolder(Phone[] phones)
        {
            this.phones = phones;

        }

        public IEnumerator GetEnumerator()
        {
            foreach (Phone phone in phones)
            {
                yield return phone;
            }
        }
    }
}
