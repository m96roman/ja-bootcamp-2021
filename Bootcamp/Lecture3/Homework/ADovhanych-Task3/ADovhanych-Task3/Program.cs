using System;

namespace ADovhanych_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Table kt = new KitchenTable { Name = "asd", Material = "sadsa" };
            Console.WriteLine(kt);
        }

        public abstract class Furniture
        {
            public string Name { get; set; }

            public string Material { get; set; }

            protected Furniture(string name, string material)
            {
                Name = name;
                Material = material;
            }

            public abstract void ActionWith();


        }


        public class Table : Furniture
        {
            public int LegCount { get; protected set; }

            private string _user;

            public Table(string name, string material, int legCount) : base(name, material)
            {
                LegCount = legCount;
            }

            public Table(string name, string material) : base(name, material)
            {

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
        }

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
}