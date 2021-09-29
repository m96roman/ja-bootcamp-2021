using System;
using System.Collections.Generic;
using System.Text;

namespace Pylat___Task_3
{
    class Task1
    {
        public static void doTask1()
        {
            Nike nike = new Nike("2", "3", 4, "5");
            nike.NameOfSneakers();

            Adidas adidas = new Adidas("1", "2", 4);
            adidas.NameOfSneakers();


            Puma puma = new Puma("1", "1", 2, 2);
            puma.NameOfSneakers();


            Something something = new Something("10", "22", 4094);
            something.ProtectM();
        }

        public abstract class Sneakers
        {
            public string firm { get; set; }
            public string model { get; set; }
            public int size { get; set; }

            protected Sneakers(string firm, string model, int size)
            {
                this.firm = firm;
                this.model = model;
                this.size = size;
            }

            public abstract void NameOfSneakers();

        }
        public class Nike : Sneakers
        {
            public Nike(string firm, string model, int size, string jpnSize) : base(firm, model, size)
            {
                this.JPNSize = jpnSize;
            }

            public string JPNSize { get; set; }

            public override void NameOfSneakers()
            {
                Console.WriteLine($"Firm is - {firm}, model is - {model}, size is -{size}, jpnsize is -{JPNSize}");
            }
        }
        public class Adidas : Sneakers
        {

            public Adidas(string firm, string model, int size) : base(firm, model, size)
            {

            }
            public override void NameOfSneakers()
            {
                PrivateMethod(3);
                Console.WriteLine($"Firm is - {firm}, model is - {model}, size is -{size}");
            }
            private void PrivateMethod(int priv)
            {

                Console.WriteLine($"number = {priv + 1}");

            }
            protected void ProtectedMethod(int prot)
            {
                Console.WriteLine($"Protected Method Output = {prot}");
            }
        }
        public class Puma : Sneakers
        {
            public const int constNumber = 10;
            public int rate { get; set; }
            public Puma(string firm, string model, int size, int rate) : base(firm, model, size)
            {
                this.rate = rate;
            }
            public override void NameOfSneakers()
            {
                Console.WriteLine($"Firm is - {firm}, model is - {model}, size is -{size}, rate - {rate}, const variable = {constNumber}");
            }


        }
        public class Something : Adidas
        {
            public readonly int readOnlyVariable;
            public string x;
            public Something(string firm, string model, int size) : base(firm, model, size)
            {
                readOnlyVariable = 3;

            }
            public Something(string x) : this("xxx", "dsfd", 4)
            {
                this.x = x;


            }

            public void ProtectM()
            {
                x = "10";

                Console.WriteLine($@"Result of protected method: { x + readOnlyVariable}
readonly variable = {readOnlyVariable}
this() inherits firm, model, size from Something ctor");
            }
        }
    }
}
