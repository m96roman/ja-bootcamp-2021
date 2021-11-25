using System.Collections.Generic;

namespace ConsoleApp6.Abstracts
{
    public abstract class Street
    {
        public string Name { get; set; }
        protected List<House> houses = new List<House>();

        public abstract void AddHouse(House house);
        public abstract void ShowAllHouses();
    }
}
