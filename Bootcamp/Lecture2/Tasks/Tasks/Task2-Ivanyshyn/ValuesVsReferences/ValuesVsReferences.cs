using System;
using Task2_Ivanyshyn.Helpers;

namespace Task2_Ivanyshyn.ValuesTasks
{
    internal class ValuesVsReferences
    {
        public static void DoTasks()
        {
            //            1.Create a structure `Marker` which have
            //    -a `color` filed of string type
            //    -a static field `index` of int type
            //    -create two instances of `Marker` with different colors and index values.
            //    -Print both instances of marker to Console -Create a method in struct PrintMarker() which will print itself to Console
            //    - Explain the result :)
            //  Task1();
            //2. Create a static method `InitMarker(string color)` which takes color as an argument and returns created `Marker` instance with that color:
            //    - create a constructor for `Marker` struct which takes color as an argument.Use it in the `InitMaker` method
            //    - if `InitMaker` is called with `null` argument `Nullable<Marker>` type should be returned.
            //    - Print marker created using `InitMaker` method: if null is returned use `??` operator to create `new Marker("default")` instead
            Task2();
            //3. Write a program to insert the information of two books. (Book struct should be created)
            //Test Data :

            //Insert the information of two books :                    
            //-----------------------------------------                
            //Information of book 1 :                                  
            //Input name of the book : BASIC
            //Input the author : S.TROELSTRA

            //Information of book 2 :                                  
            //Input name of the book : C+                              
            //Input the author : G.RTRTG

            //Expected Output:

            //1: Title = BASIC,  Author = S.TROELSTRA                  

            //2: Title = C+,  Author = G.RTRTG

            //Task3();
        }

        private static void Task3()
        {
            Book book1 = new Book(Reader.ReadString(name: "Input name of the book"), Reader.ReadString(name: "Input author of book"));


            Book book2 = new Book(Reader.ReadString(name: "Input name of the book"), Reader.ReadString(name: "Input author of book")); 
            Console.WriteLine(book1);
            Console.WriteLine(book2);
        }

        private static void Task2()
        {
            Console.WriteLine(Marker.InitMarker(null) ?? new Marker("default"));
        }

        private static void Task1()
        {
            Marker marker = new Marker("green", 20);
            Marker marker1 = new Marker("red", 40);
            Console.WriteLine(marker);
            Console.WriteLine(marker1);

            //Explanation:
            // index is static so if we change it, we change it for all intances of marker
        }
    }
}
