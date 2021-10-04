using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class DomesticPackage : Package
    {
        public DomesticPackage(int size, string title, string recipient, int departmentId) 
            : base(size, title, recipient)
        {
            DepartmentId = departmentId;
        }

        public int DepartmentId { get; set; }
    }
}
