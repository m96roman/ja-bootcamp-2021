using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._4
{
    public class InvalidPhoneChargeException : Exception
    {
        public InvalidPhoneChargeException() { }
        public InvalidPhoneChargeException(string message) : base(message) { }

    }
}
