using System;

namespace Task2_Observer
{
    class Businessman : ISubscriber
    {
        public string Name { get; set; }

        public Businessman(string name)
        {
            Name = name;
        }

        public void Update(string context)
        {
            Console.WriteLine($"\nBusinessman {Name} received notification: {context}");
        }
    }
}
