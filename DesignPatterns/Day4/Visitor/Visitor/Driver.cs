using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Driver : IComponent
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Date DateOfBirthday { get; set; }
        public long DriverLicenseNumber { get; set; }
        public Date DateIssueDriverLicense { get; set; }

        public Driver() 
        { 
        }

        public void InfoSerialize(IVisitor visitor)
        {
            visitor.VDriver(this);
        }
    }
}
