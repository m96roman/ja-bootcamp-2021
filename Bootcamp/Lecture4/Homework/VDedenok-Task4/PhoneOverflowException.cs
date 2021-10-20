using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task4
{
    class PhoneOverflowException : Exception
    {
        public String ShowMessage { get; set; }
        public PhoneOverflowException(string message)
        {
            this.ShowMessage = message;
        }
    }
}
