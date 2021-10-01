using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class DbResult<T>
    {
        public bool IsSuccede { get; set; }

        public T Value { get; set; }

    }
}
