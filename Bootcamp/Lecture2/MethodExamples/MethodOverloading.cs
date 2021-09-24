using System;

public static class MethodOverloading
{
    public static void ShowExample()
    {
        Console.WriteLine("***** Fun with Method Overloading *****\n");

        // Calls int version of Add()
        Console.WriteLine(Add(10, 10));

        // Calls long version of Add() (using the new digit separator)
        Console.WriteLine(Add(900_000_000_000, 900_000_000_000));

        // Calls double version of Add()
        Console.WriteLine(Add(4.3, 4.4));

        Console.ReadLine();
    }

    // Overloaded Add() method.

    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Add(int x, int y, int z = 0)
    {
        return x + (y * z);
    }

    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static long Add(long x, long y)
    {
        return x + y;
    }
}