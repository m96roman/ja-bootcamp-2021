using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_task5._3
{
    class DbResult<T>
    {
        public bool IsSucceded { get; set; }

        public T Value { get; set; }
    }
}
