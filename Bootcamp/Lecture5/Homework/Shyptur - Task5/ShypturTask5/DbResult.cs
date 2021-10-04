using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    class DbResult<T>
    {
        public bool IsSucceded { get; set; }
        public T Value { get; set; }
        public DbResult(bool issuccede, T value)
        {
            IsSucceded = issuccede;
            Value = value;
        }
    }
}
