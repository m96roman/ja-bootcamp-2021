using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task3
{
    public class KitchenTable : Table
    {
        public KitchenTable(string name, string material, int legCount) : base(name, material, legCount) { }

        public KitchenTable() : this(null, null, 0) { }

        public override void ActionWith()
        {
            base.ActionWith();
            Console.WriteLine("Neccessary on Kitchen");
        }

        protected override void ActionWithTabel()
        {
            Console.WriteLine("Kitchen table");
        }

        public void SetLegCount(int legCount)
        {
            LegCount = legCount;
        }
    }
}
