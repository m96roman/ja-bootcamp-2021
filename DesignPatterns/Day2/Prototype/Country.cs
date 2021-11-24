using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Country:Prototype
    {
        private string Name { get; set; }

        public List<City> Cities =new List<City>();
        public List<Region> Regions= new List<Region>();

        public Country(string name,City city,Region region )
        {
            Name = name;
            Cities.Add(city);
            Regions.Add(region);
        }

        public override Prototype Copy()
        {
            Country clone = (Country)this.MemberwiseClone();
            clone.Name = string.Copy(Name);
            clone.Cities = Cities.Select(city => city.Copy() as City).ToList();
            clone.Regions = Regions.Select(region => region.Copy() as Region).ToList();
            return clone;
        }

        public void ChangePopulation(string name, int population)
        {
            Cities.Find(s => s.Name == name).Population = population;
        }

        public void ChangeRegionName(string oldName, string newName)
        {
            Regions.Find(s => s.Name == oldName).Name = newName;
        }

        public void Print()
        {
            Console.WriteLine($"Country : {Name}:");
           
            Console.WriteLine("Cities :");

            foreach (var city in Cities)
            {
                Console.WriteLine($"City: {city.Name} Population: {city.Population}");
            }

            Console.WriteLine("Regions :");

            foreach (var region in Regions)
            {
                Console.WriteLine($"Region: {region.Name} Square: {region.Square}");
            }
        }

   
    }
}
