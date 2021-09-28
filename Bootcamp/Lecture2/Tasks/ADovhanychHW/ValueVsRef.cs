using System;

class ValueVsRef
{
    public static void MarkerTask()
    {
        Marker Marker1;
        Marker Marker2;

        Marker1.color = "red";
        Marker.index = 2;
        Marker2.color = "black";
        Marker.index = 4;

        Marker1.PrintMarker();
        Marker2.PrintMarker();
    }

    public struct Marker
    {
        public string color;
        public static int index;

        public Marker(string color)
        {
            this.color = color;
        }

        public void PrintMarker()
        {
            Console.WriteLine($"Color of the marker is {color}, index: {index}");
        }

        public static Marker? InitMarker(string color)
        {
            if(color == null)
            {
                return new Marker?();
            }

            return new Marker(color);
        }
        
        public static void DisplayInitMark(string color)
        {
            Marker marker = InitMarker(color) ?? new Marker("default");
            marker.PrintMarker();
        }

    }

    public static void BookInfo()
    {
        Books Book1;
        Books Book2;

        Console.WriteLine("Information of the first book");
        Console.Write("Input name of the first book: ");
        Book1.Title = Console.ReadLine();
        Console.Write("Input author of the first book:");
        Book1.Author = Console.ReadLine();

        Console.WriteLine("Information of the second book");
        Console.Write("Input name of the second book:");
        Book2.Title = Console.ReadLine();
        Console.Write("Input author of the second book:");
        Book2.Author = Console.ReadLine();

        Console.WriteLine($"1: Title = {Book1.Title},  Author = {Book1.Author}");
        Console.WriteLine($"2: Title = {Book2.Title},  Author = {Book2.Author}");


    }

    struct Books
    {
        public string Title;
        public string Author;
    }
}
