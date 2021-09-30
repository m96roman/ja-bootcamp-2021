using System;
using System.Collections.Generic;
using System.Text;

namespace Pylat___Task_3
{
    class Task1
    {
        public static void DoTask1()
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
            public string Firm { get; set; }
            public string Model { get; set; }
            public int Size { get; set; }

            protected Sneakers(string firm, string model, int size)
            {
                this.Firm = firm;
                this.Model = model;
                this.Size = size;
            }

            public abstract void NameOfSneakers();
        }

        public class Nike : Sneakers
        {
            public Nike(string firm, string model, int size, string jpnSize) : base(firm, model, size)
            {
               JPNSize = jpnSize;
            }

            public string JPNSize { get; set; }

            public override void NameOfSneakers()
            {
                Console.WriteLine($"Firm is - {Firm}, Model is - {Model}, Size is -{Size}, jpnSize is -{JPNSize}");
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
                Console.WriteLine($"Firm is - {Firm}, Model is - {Model}, Size is -{Size}");
            }

            private void PrivateMethod(int priv)
            {
                Console.WriteLine($"number = {priv + 1}");

            }

            
        }
        public class Puma : Sneakers
        {
            public const int constNumber = 10;
            public int Rate { get; set; }
            public Puma(string firm, string model, int size, int rate) : base(firm, model, size)
            {
                this.Rate = rate;
            }

            public override void NameOfSneakers()
            {
                Console.WriteLine($"Firm is - {Firm}, Model is - {Model}, Size is -{Size}, rate - {Rate}, const variable = {constNumber}");
            }


        }
        public class Something : Adidas
        {
            public readonly int ReadOnlyVariable;
            public string X;
            public Something(string firm, string model, int size) : base(firm, model, size)
            {
                ReadOnlyVariable = 3;

            }

            public Something(string x) : this("xxx", "dsfd", 4)
            {
                this.X= x;
            }

            public void ProtectM()
            {
                X = "10";

                Console.WriteLine($@"Result of protected method: { X + ReadOnlyVariable}
readonly variable = {ReadOnlyVariable}
this() inherits Firm, Model, Size from Something ctor");
            }
        }
    }
}
