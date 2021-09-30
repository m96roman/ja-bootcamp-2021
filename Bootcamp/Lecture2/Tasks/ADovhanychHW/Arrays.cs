using System;

public static class Arrays
{
    public static void ReversArr()
    {
        Console.WriteLine("Enter number of elements in arr:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Input {n} elements in arr");

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} :");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The values store into the array are :");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]}");
        }

        Console.WriteLine("\nThe values store into the array in reverse are : ");

        Array.Reverse(arr);

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]}");
        }

    }

    public static void Duplicate()
    {

        Console.WriteLine("Enter number of elements in arr:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Input {n} elements in arr");

        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} :");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                    break;
                }
            }
        }

        Console.WriteLine($"Total number of duplicate elements found in the array is: {counter}");
        Console.ReadLine();
    }
}
