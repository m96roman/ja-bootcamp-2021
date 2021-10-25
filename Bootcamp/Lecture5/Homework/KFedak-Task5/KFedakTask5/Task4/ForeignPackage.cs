using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class ForeignPackage : Package
    {
        public ForeignPackage(string senderCountry, int size, string title, string recipient) : base(size, title, recipient)
        {
            SenderCountry = senderCountry;
        }

        public string SenderCountry { get; set; }
    }
}
