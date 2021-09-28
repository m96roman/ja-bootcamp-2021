using System;

public static class Arrays
{
    public static void ReversArr()
    {
        int i, n;
        int[] arr = new int[100];

        Console.WriteLine("Enter number of elements in arr:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Input {n} elements in arr");

        for (i = 0; i < n; i++)
        {
            Console.Write($"element - {i} :");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The values store into the array are :");

        for (i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]}");
        }

        Console.WriteLine("\nThe values store into the array in reverse are : ");

        for (i = n - 1; i >= 0; i--)
        {
            Console.Write($"{arr[i]}");
        }

    }

    public static void Duplicate()
    {
        int i, n, j;
        int[] arr = new int[100];
        int counter = 0;

        Console.WriteLine("Enter number of elements in arr:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Input {n} elements in arr");

        for (i = 0; i < n; i++)
        {
            Console.Write($"element - {i} :");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine($"Total number of duplicate elements found in the array is: {counter}");
        Console.ReadLine();
    }
}
