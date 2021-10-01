using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class DomesticPackage : Package
    {
        public int DepartmentId { get; set; }

        public DomesticPackage(int id, int size, string title, string recipient) : base(size, title, recipient)
        {
            DepartmentId = id;
        }
    }
}
