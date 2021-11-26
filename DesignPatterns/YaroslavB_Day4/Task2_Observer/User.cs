using System;

namespace Task2_Observer
{
    class User : ISubscriber
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(string context)
        {
            Console.WriteLine($"\nUser {Name} received notification: {context}");
        }
    }
}
