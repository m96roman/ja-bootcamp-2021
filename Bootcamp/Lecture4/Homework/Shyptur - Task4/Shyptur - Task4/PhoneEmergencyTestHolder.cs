using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur___Task4
{
    class PhoneEmergencyTestHolder : IEnumerable
    {
        private Phone[] Phones;

        public PhoneEmergencyTestHolder(Phone[] phones)
        {
            this.Phones = phones;
        }

        IEnumerator IEnumerable.GetEnumerator() => Phones.GetEnumerator();
  
    }
}
