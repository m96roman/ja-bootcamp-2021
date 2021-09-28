using System;

namespace Task2_Ivanyshyn.ValuesTasks
{
    struct Marker
    {
        public string color;
        public static int index;
        static Marker()
        {
            index = 1;
        }
        public Marker(string color)
        {
            this.color = color;
        }

        public Marker(string color, int index)
        {
            this.color = color;
            //Yea thats kinda bad
            Marker.index = index;
        }
        public override string ToString()
        {
            return $"color - {color} Index - {index}";
        }
        public static Marker? InitMarker(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                return null;
            }
            return new Marker(color);
        }
    }
}