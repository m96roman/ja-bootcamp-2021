using System;

namespace Task2_Observer
{
    class UtilityService : ISubscriber
    {
        public string Name { get; set; }

        public UtilityService(string name)
        {
            Name = name;
        }

        public void Update(string context)
        {
            Console.WriteLine($"\nUtility Service {Name} received notification: {context}");
        }
    }
}
