using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur_Task9_HW
{
    public class PhoneEmergencyTestHolder : IEnumerable
    {
        Phone[] Phones;

        public PhoneEmergencyTestHolder(Phone[] phones)
        {
            this.Phones = phones;
        }

        IEnumerator IEnumerable.GetEnumerator() => Phones.GetEnumerator();
    }
}
