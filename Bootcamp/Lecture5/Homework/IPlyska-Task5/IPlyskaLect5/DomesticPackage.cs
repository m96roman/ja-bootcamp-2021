using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class DomesticPackage : Package
    {
        public int DepartmentId { get; set; }
        public DomesticPackage(string size, string title, string recipient, int departmentId) : base(size, title, recipient)
        {
            DepartmentId = departmentId;
        }
    }
}
