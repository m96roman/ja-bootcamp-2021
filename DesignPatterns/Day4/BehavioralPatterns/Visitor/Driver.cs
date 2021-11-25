using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Driver : IElement
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int DriveLicenseNumber { get; set; }
        public int Year { get; set; }

        public void Show(IVisitor visitor)
        {
            visitor.VisitDriver(this);
        }
    }
}
