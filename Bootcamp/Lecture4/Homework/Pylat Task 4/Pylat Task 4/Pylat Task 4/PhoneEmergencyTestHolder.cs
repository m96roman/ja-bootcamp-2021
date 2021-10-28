using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pylat_Task_4
{

    class PhoneEmergencyTestHolder : IEnumerable<PhoneBase>
    {
        private List<PhoneBase> _phones;

        public PhoneEmergencyTestHolder()
        {
            _phones = new List<PhoneBase>();
        }
    
        public void Add(PhoneBase item)
        {
            _phones.Add(item);
        }

        public IEnumerator<PhoneBase> GetEnumerator()
        {
            foreach (var item in _phones)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
