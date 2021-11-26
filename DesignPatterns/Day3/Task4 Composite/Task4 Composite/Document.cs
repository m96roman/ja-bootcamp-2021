using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_Composite
{
    class Document : CompositeFolder
    {
        public Document(string name) : base(name)
        { }
        public bool CanHoldChildren { get { return false; } }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
