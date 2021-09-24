using System;

namespace ImplicitlyTypesLocalVarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Implicit Typing *****");

            DeclareImplicitVars();
            DeclareImplicitNumerics();
            ImplicitTypingIsStrongTyping();
            Console.WriteLine("Get an int {0}", GetAnInt());
            Console.WriteLine();
            Console.ReadKey();
        }

        static void DeclareImplicitVars()
        {
            // Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        static void DeclareImplicitNumerics()
        {
            // Implicitly typed numeric variables.
            var myUInt = 0u;
            var myInt = 0;
            var myLong = 0L;
            var myDouble = 0.5;
            var myFloat = 0.5F;
            var myDecimal = 0.5M;

            // Print out the underlying type.
            Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
            Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
            Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
            Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
        }

        static int GetAnInt()
        {
            var retVal = 9;
            return retVal;
        }

        static void ImplicitTypingIsStrongTyping()
        {
            // The compiler knows "s" is a System.String.
            var s = "This variable can only hold string data!";
            s = "This is fine...";

            // Can invoke any member of the underlying type.
            string upper = s.ToUpper();

            // Error! Can't assign numerical data to a a string!
            // s = 44;
        }
    }
}
