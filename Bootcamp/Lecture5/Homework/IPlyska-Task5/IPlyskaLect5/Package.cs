using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class Package
    {
        public string Size { get; set; }
        public string Title { get; set; }
        public string Recipient { get; set; }

        public Package(string size, string title, string recipient)
        {
            Size = size;
            Title = title;
            Recipient = recipient;
        }
    }
}
