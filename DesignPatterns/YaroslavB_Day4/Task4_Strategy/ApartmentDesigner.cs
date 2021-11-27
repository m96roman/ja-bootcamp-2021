using System;

namespace Task4_Strategy
{
    partial class Program
    {
        class ApartmentDesigner
        {
            public void UpdateDesignInRoom(string room, IExpert master)
            {
                Console.WriteLine($"\nDecoration of {room}:");
                master.Decorate();
            }
        }
    }
}
