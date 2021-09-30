using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    public class InvalidPhoneChargeException : Exception
    {
        public InvalidPhoneChargeException()
        {
            Console.WriteLine("invalid charge value");
        }

        public InvalidPhoneChargeException(string message) : base(message) { }

        public InvalidPhoneChargeException(string message, Exception inner) : base(message, inner) { }

        protected InvalidPhoneChargeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
