using System;

namespace YaroslavB_Task5
{
    public struct Rectangle : IDrawable
    {
        public Point AB { get; }
        public Point BC { get; }
        public Point CA { get; }

        /// <summary>
        /// Initialize a triangle with it's three sgments: A, B and C
        /// </summary>
        /// <param name="ab">Point of connection of segments: AB</param>
        /// <param name="bc">Point of connection of segments: BC</param>
        /// <param name="ca">Point of connection of segments: CA</param>
        public Rectangle(Point ab, Point bc, Point ca)
        {
            AB = ab;
            BC = bc;
            CA = ca;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawn triangle with vertices:");
            AB.DrawVertex(nameof(AB));
            BC.DrawVertex(nameof(BC));
            CA.DrawVertex(nameof(CA));
        }

    }

}
