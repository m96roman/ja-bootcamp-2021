using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class DbResult<T>
    {
        public bool IsSucceded { get; }
        public T Value { get; }

        public DbResult(bool isSucceded, T value)
        {
            IsSucceded = isSucceded;
            Value = value;
        }
    }
}
