using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is JOE, he is penguin. He...");
            Animals Penquin = new Birds();
            Penquin.HasTail = false;
            Penquin.favouriteFood("fish");
            Penquin.ShowRunSpeed();
            Animals Tiger = new Mammals();
            Tiger.HasTail = true;
            Tiger.ShowMesures(65.0, 150);    
            Cats Puma = new Cats();
            Puma.BabiesLike("meat");
            Mammals Elephant = new Mammals();
            Elephant.BabiesLike("apples;");
            Birds Sparrow = new Birds();
            Sparrow.favouriteFood("seeds");
            Sparrow.ShowMeFacts();
            Sparrow.OneMoreFact();
        }
        
        //Abstruct class
        public abstract class Measures
        {
      
            public void ShowMesures(double Wieght, double Height)
            {
                Console.WriteLine($"The weigth is {Wieght} kilos, height is {Height} centimetres");
            }
            //Abstruct method
            public abstract void ShowRunSpeed();
        }
     


        public class Animals : Measures
            {
           
            public string AnimalName = "Some animal name";
         
            //Override abstruct method
            public override void ShowRunSpeed()
            {
                Console.WriteLine("The runspeed we do not know)!");
            }
            public bool HasTail
            {
                set
                {
                    if (value == true)
                    {
                        Console.WriteLine("Has tail!");
                    }
                    else
                    {
                        Console.WriteLine("Does not have a tail!");
                    }
                }
            }
            public void favouriteFood(string food)
            {
                Console.WriteLine($"Like to eat {food}");
            }

            //Protected Method
            protected void ShowName(string name)
            {
                Console.WriteLine($"The name of this animal is {name}");
            }
        }

        public class Mammals : Animals
        {

            //Virtual method
            public virtual void BabiesLike(string BabiesFood)
            {
                ShowName("here must be a name in protected method");
                Console.WriteLine($"like {BabiesFood}");
            }    
        }

        public class Cats : Mammals
        {
            //virtual override method
            public override void BabiesLike(string BabyFood)

            {
                Console.WriteLine($"Mammls babies like not only {BabyFood}");
            }
        }

        public class Birds : Animals
        {
            //readonly int
            public readonly string redonlyBirdFact = "Here is some readonly string text.";
            //private method
            private void BirdFacts()
            {
     
                Console.WriteLine($"Ostrith is the fastest running bird.");
            }
         
            public void ShowMeFacts()
            {
                //const str
                const string AnotherBirdFacts = "Here must be another bird fact.";        
                BirdFacts();
                Console.WriteLine($"hello {AnotherBirdFacts}");
            }

            public void OneMoreFact()
            {    
                 Console.WriteLine($"{redonlyBirdFact}");
            }
        }

    }
}




/*1. Design own class hierarchy. Display how it works by calling methods as in examples.
Requirements:
	- should have abstract and virtual methods
	- should have constructors chaining (this(), base())
	- at least one method with use of "base" keyword
	- should have private/protected/public methods
	- use object inializer
	- classes should have properties and fields
	- use static/readonly/const keywords
	- NOT LIMITED BY ABOVE STATEMENTS

Example: 
Cars, Musical instruments, Shapes*/