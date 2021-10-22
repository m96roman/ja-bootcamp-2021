using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SolveEquation
{
    public class NoRootsException : Exception
    {
        public NoRootsException()
        {
        }

        public NoRootsException(string message) : base(message)
        {
        }

        public NoRootsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoRootsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
