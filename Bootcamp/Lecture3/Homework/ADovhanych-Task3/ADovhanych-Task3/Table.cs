using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task3
{
    public class Table : Furniture
    {
        public int LegCount { get; protected set; }

        private string _user;

        public Table() : this("Glass table", "glass", 3) { }

        public Table(string name, string material, int legCount) : base(name, material)
        {
            LegCount = legCount;
        }

        public override void ActionWith()
        {
            Console.WriteLine($"Sit on {Name}");
        }

        protected virtual void ActionWithTabel()
        {
            Console.WriteLine("Table");
        }

        public void SetUser(string user)
        {
            _user = user + "Table";
        }

        public override void LayOn()
        {
            Console.WriteLine($"Mate, you can't lay on {Name}");
        }
    }
}
