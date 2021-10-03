using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class ForeignPackage : Package
    {
        public string SenderCountry { get; set; }

        public ForeignPackage(string size, string title, string recipient, string senderCountry) : base(size, title, recipient)
        {
            SenderCountry = senderCountry;
        }
    }
}
