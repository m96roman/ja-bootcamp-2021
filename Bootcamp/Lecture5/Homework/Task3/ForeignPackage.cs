using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class ForeignPackage : Package
    {
        public string SenderCountry { get; set; }
        public ForeignPackage(int size, string title, string recipient, string senderCountry) 
            : base(size, title, recipient)
        {
            SenderCountry = senderCountry;
        }
    }
}
