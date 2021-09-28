using System;

namespace MarkerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Marker marker1 = new Marker(1, "blue");
            Marker marker2 = new Marker(2, "red");

            Marker.PrintMarker(marker1);
            Marker.PrintMarker(marker2);

            Marker.PrintInitMarker(null);
        }

        struct Marker
        {
            public static int index;
            public string color;

            static Marker()
            {
                index = 1;
            }
            
            public Marker(int index, string color)
            {
                Marker.index = index;
                this.color = color;
            }

            public Marker(string color)
            {
                this.color = color;
            }

            public static void PrintMarker(Marker marker)
            {
                Console.WriteLine($"Marker index is: {index} and color is: {marker.color}");
            }

            //Because Index is the same for all instacess of clasess

            public static Marker? InitMarker(string color)
            {
                if (string.IsNullOrWhiteSpace(color))
                {
                    return new Marker?();
                }
                return new Marker(color);
            }

            public static void PrintInitMarker(string color)
            {
               PrintMarker(Marker.InitMarker(color) ?? new Marker("default"));
            }
        }
    }
}
