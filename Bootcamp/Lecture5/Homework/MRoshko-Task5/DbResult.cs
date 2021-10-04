using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task5
{
    public class DbResult<T>
    {
        public bool IsSucceded { get; set; }
        public T Value { get; set; }
    }
}
