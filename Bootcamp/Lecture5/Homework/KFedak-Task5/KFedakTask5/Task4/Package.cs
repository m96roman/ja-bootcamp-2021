using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class Package
    {
        public int Size { get; set; }
        public string Title { get; set; }
        public string Recipient { get; set; }

        public Package(int size, string title, string recipient)
        {
            Size = size;
            Title = title;
            Recipient = recipient;
        }

    }
}
