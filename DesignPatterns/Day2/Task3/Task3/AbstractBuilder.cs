using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildEngine(double power);
        public abstract void BuildDiskDiameter(int d);
        public abstract void BuildHeatedSeets(string boolean);
        public abstract string GetResult();
    }
}
