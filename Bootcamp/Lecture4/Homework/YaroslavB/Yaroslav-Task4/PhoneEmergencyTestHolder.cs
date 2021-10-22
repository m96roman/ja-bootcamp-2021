using System.Collections;
using System.Collections.Generic;

namespace Yaroslav_Task4
{
    class PhoneEmergencyTestHolder : IEnumerable<MobilePhone>
    {
        private List<MobilePhone> _mobilePhones = new List<MobilePhone>();

        public PhoneEmergencyTestHolder()
        {

        }

        public IEnumerator<MobilePhone> GetEnumerator()
        {
            return _mobilePhones.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _mobilePhones.GetEnumerator();
        }

        public void Add(MobilePhone phone)
        {
            _mobilePhones.Add(phone);
        }
    }
}
