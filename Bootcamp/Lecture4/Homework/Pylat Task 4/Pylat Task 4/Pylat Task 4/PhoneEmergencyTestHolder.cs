using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pylat_Task_4
{
    
    class PhoneEmergencyTestHolder: IEnumerable // inherit ienumerable
    {
       

        public PhoneBase[] _items;

        int freeIndex = 0;

        public void TestEmergency(PhoneEmergencyTestHolder phone)
        {
           
            
        }

        public PhoneEmergencyTestHolder()
        {
            _items = new PhoneBase[1000];
        }


        public void Add(PhoneBase item)
        {
            _items[freeIndex] = item;
            freeIndex++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object o in _items)
            {
                if (o == null)
                {
                    break;
                }
                yield return o;
            }
        }       
    }
}
