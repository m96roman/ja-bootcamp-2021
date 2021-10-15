using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProject
{
    public class Package
    {
        public int Size { get; set; }
        public string Title { get; set; }
        public string Recipient { get; set; }
    }

    public class ForeignPackage : Package
    {
        public string SenderCountry { get; set; }
    }

    public class DomesticPackage : Package
    {
        public int DepartmentId { get; set; }
    }
}
