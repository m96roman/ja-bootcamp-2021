using System;

public static class StructureExamples
{
    public static void ShowExample()
    {
        Console.WriteLine("***** A First Look at Structures *****\n");
        // Create an initial Point.
        Point myPoint;
        myPoint.X = 349;
        myPoint.Y = 76;
        myPoint.Display();

        // Adjust the X and Y values.
        myPoint.Increment();
        myPoint.Display();

        // Set all fields to default values
        // using the default constructor.
        Point p1 = new Point();

        // Prints X=0,Y=0
        p1.Display();

        // Call custom constructor.
        Point p2 = new Point(50, 60);

        // Prints X=50,Y=60
        p2.Display();


        PointWithReadOnly p3 = new PointWithReadOnly(50, 60, "Point w/RO");
        p3.X = 70;
        //Can no longer do this
        //p3.Y = 90;
        p3.Display();

        Console.ReadKey();
    }

    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;

        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            X++; Y++;
        }

        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--; Y--;
        }

        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        // A custom constructor.
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
    }
    readonly struct ReadOnlyPoint
    {
        // Fields of the structure.
        public readonly int X;
        public int Y { get; }

        // Display the current position and name.
        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        // A custom constructor.
        public ReadOnlyPoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

    }
    struct PointWithReadOnly
    {
        // Fields of the structure.
        public int X;
        public readonly int Y;
        public readonly string Name;

        // Display the current position and name.
        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
        }

        // A custom constructor.
        public PointWithReadOnly(int xPos, int yPos, string name)
        {
            X = xPos;
            Y = yPos;
            Name = name;
        }
    }

    struct NormalPoint
    {
        //This will not compile
        //public PointWithRef PropPointer { get; set; }
    }
}
