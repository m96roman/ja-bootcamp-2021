using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class Test
    {
        public readonly string Id= Guid.NewGuid().ToString("N");
        public List<string> Question { get; set; }

        public Test(List<string> question)
        {
            Question = new List<string>();
            Question = question;
        }

        public virtual void Print()
        {
        }
    }
}
