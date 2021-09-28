using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //created instances
            Marker firstColor = new Marker("Yellow", 34);
            Marker secondColor = new Marker("Green", 14);

            //printing both instances of marker to Console
            firstColor.PrintMarker();
            secondColor.PrintMarker();


            Marker newColor = InitMarker("greenAndYellow");

            Marker? newColorNullable = InitMarker(null);
            newColorNullable = newColorNullable ?? new Marker("default");            

        }


        //created structure 'Marker'
        struct Marker
        {
            public string _color; //string is nullable type
            static int _index;

            public Marker(string color)
            {
                _color = color;
            }

            public Marker(string color, int index)
            {
                _color = color;
                _index = index;
            }

            public void PrintMarker()
            {
                Console.WriteLine($"Color name -> {_color}, color index -> {_index}");
            }
        }

        // Created a static method `InitMarker(string color)` 
        // which takes color as an argument and returns created `Marker` instance with that color
        static Marker InitMarker(string color)
        {
            return new Marker(color);
        }
    }
}
