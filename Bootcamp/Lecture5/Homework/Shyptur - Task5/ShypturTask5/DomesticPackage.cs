using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public class DomesticPackage : Package
    {
        public int DepartmentId { get; set; }
        public DomesticPackage(double size, string title, string recipient, int departmentID) : base(size, title, recipient)
        {
            DepartmentId = departmentID;
        }
    }
}
