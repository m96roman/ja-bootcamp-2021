using System;

namespace Task2
{
    /// <summary>
    /// Task 1, Task 2
    /// </summary>
    struct Marker
    {
        private string _color;

        public static int Index { get; set; }

        public Marker(string color)
        {
            _color = color;
        }

        public void Printmarker()
        {
            Console.WriteLine($" color: {_color}\n" +
                              $" index: {Index}");
        }
    }
}
