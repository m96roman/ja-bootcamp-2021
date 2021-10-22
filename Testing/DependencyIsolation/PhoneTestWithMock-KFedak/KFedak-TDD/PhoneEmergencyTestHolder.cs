using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    public class PhoneEmergencyTestHolder : IEnumerable
    {
        public List<Phone> telephones = new();

        public PhoneEmergencyTestHolder(List<Phone> phones)
        {
            this.telephones = phones;
        }

        IEnumerator IEnumerable.GetEnumerator()
           => telephones.GetEnumerator();
    }
}
