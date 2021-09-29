using System;

namespace IuriiPlyskaLect3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Show Abstract class works
            //Phone nokia = new Nokia();
            //nokia.Test();
            //Console.WriteLine($"Serial number for {nameof(nokia)} is {nokia.SerialNumber}, color is {nokia.color}, and size of display is {nokia.Inch = 2} inch");
            //nokia.PrintModel();
            //nokia.GetManufacturer();

            //Phone samsung = new Samsung();
            //samsung.Test();
            //Console.WriteLine($"Serial number for {nameof(samsung)} is {samsung.SerialNumber = "19M2345KZ"}, color is {samsung.color}, and size of display is {samsung.Inch = 5.9} inch"); ///can not change color due to readonly
            //samsung.PrintModel();
            //samsung.GetManufacturer();

            ////to show hiding
            //Samsung samsung1 = new Samsung();
            //samsung1.Test();

            #endregion

            ///For demo chaining
            //Animal animal = new Animal() {IsFly = false, IsSwim = false};
            //Animal animal1 = new Animal(4) {Weight = 60};
            //Animal animal2 = new Animal(6, "black");
            ////////////

            ///For demo inheritance
            //Animal cat = new Cat() { IsFly = false, IsSwim = true, Weight = 2};
            //cat.GetSound();
            //Console.WriteLine($"Cat has {Cat.paws} paws");

            //Animal dog = new Dog() { IsFly = false, IsSwim = true, Weight = 5};
            //dog.GetSound();

            //Console.WriteLine($"Dog has {Dog.paws} paws");

            /***********************Task2**************** */
            History test1 = new HistoryCaseQuestion()
            {
                Id = 1,
                Question = "When was start the second world war",
                A = "1914",
                B = "1939",
                C = "1941",
                D = "1945",
                CorrectAnswer = "B"
            };

            History test2 = new HistoryCaseQuestion()
            {
                Id = 2,
                Question = "In which country is the Bay of Pigs?",
                A = "USA",
                B = "Cuba",
                C = "Mexico",
                D = "Spain",
                CorrectAnswer = "B"
            };

            History test3 = new HistoryCaseQuestion()
            {
                Id = 2,
                Question = "In which country is the Bay of Pigs?",
                A = "USA",
                B = "Cuba",
                C = "Mexico",
                D = "Spain",
                CorrectAnswer = "B"
            };

        }
    }

    abstract class Phone
    {
        /// <summary>
        /// Serial Number of phone
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Color of phone
        /// </summary>
        public readonly string color;

        /// <summary>
        /// Inch of display
        /// </summary>
        public abstract double Inch { get; set; }


        public Phone()
        {
            SerialNumber = "Default";
            Inch = 6;
            color = "Black";
        }

        /// <summary>
        /// Method to print model of phone
        /// </summary>
        public abstract void PrintModel();

        /// <summary>
        /// Method to print manufacturer of phone
        /// </summary>
        public abstract void GetManufacturer();

        /// <summary>
        /// Method just for Test
        /// </summary>
        public void Test()
        {
            Console.WriteLine("Test");
        }

    }

    class Nokia : Phone
    {
        public override double Inch { get; set; }


        public override void GetManufacturer()
        {
            Console.WriteLine("Manufacturer is Nokia ");
        }

        public override void PrintModel()
        {
            Console.WriteLine("Model is Nokia 3310");
        }
    }

    class Samsung : Phone
    {
        public override double Inch { get; set; }

        public override void GetManufacturer()
        {
            Console.WriteLine("Manufacturer is Nolia");
        }

        public override void PrintModel()
        {
            Console.WriteLine("Model is Samsung M2");
        }

        /// <summary>
        /// Hide base Method
        /// </summary>
        new public void Test()
        {
            Console.WriteLine("Test for samsung");
        }
    }

    public class Animal
    {

        private static int size;

        private int paws;

        private string color;

        protected private string AreaOfLiving; 

        public int Weight { get; set; }

        public bool IsFly { get; set; }

        public bool IsSwim { get; set; }

        static Animal()
        {
            Console.WriteLine("It is static constructor");
        }

        public Animal() : this(default)
        {
            Console.WriteLine("Base Animal without parameters");
        }

        public Animal(int paws) : this (paws, string.Empty)
        {
            Console.WriteLine("Base Animal with one parameter");
        }

        public Animal(int paws, string color)
        {
            if (paws <= 0)
            {
                Console.WriteLine("Quantity of paws can not be less or qual zero");
                return;
            }
            this.paws = paws;
            this.color = color;

            Console.WriteLine("Base Animal with two parameters");
        }
        public virtual void GetSound()
        {
            Console.WriteLine("Gav - Gav");
        }

        protected static void GetName(string name)
        {
            Console.WriteLine("Base neme is" + name);
        }
    }

    class Cat : Animal
    {
        new public const int paws = 4;

        public override void GetSound()
        {
            Console.WriteLine("Mauy - Mauy");
        }
    }

    class Dog : Animal
    {
        new public const int paws = 4;

        public override void GetSound()
        {
            base.GetSound();
        }

        public void SetArrea(string area)
        {
            Console.WriteLine(this.AreaOfLiving = area); 
        }

    }
}
