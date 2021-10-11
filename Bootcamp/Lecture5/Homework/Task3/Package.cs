using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public abstract class Package
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
