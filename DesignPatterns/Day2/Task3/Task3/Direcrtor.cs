using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Direcrtor
    {
        private AbstractBuilder _builder;

        public AbstractBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalProduct()
        {
            _builder.BuildEngine(1.5);
            _builder.BuildDiskDiameter(15);
            _builder.BuildHeatedSeets("No");
            Console.WriteLine($@"{_builder.GetResult()} Minimal");
        }

        public void BuildPremiumProduct()
        {
            _builder.BuildEngine(1.8);
            _builder.BuildDiskDiameter(16);
            _builder.BuildHeatedSeets("No");
            Console.WriteLine($@"{_builder.GetResult()} Premium");
        }

        public void BuildSuperMegaProduct()
        {
            _builder.BuildEngine(1.81);
            _builder.BuildDiskDiameter(16);
            _builder.BuildHeatedSeets("Yes");
            Console.WriteLine($@"{_builder.GetResult()} SuperMega");
        }
    }
}
