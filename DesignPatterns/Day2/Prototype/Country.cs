using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Country
    {
        private string Name { get; set; }

        public List<City> cities =new List<City>();
        public List<Region> regions= new List<Region>();

        public Country(string name,City city,Region region )
        {
            Name = name;
            cities.Add(city);
            regions.Add(region);
        }

        public Country Copy()
        {
            Country clone = (Country)this.MemberwiseClone();
            clone.cities = DeepClone(cities);
            clone.regions = DeepClone(regions);
            clone.Name = String.Copy(Name);
            return clone;
        }

        public void ChangePopulation(string name, int population)
        {
            cities.Find(s => s.Name == name).Population = population;
        }

        public void ChangeRegionName(string oldName, string newName)
        {
            regions.Find(s => s.Name == oldName).Name = newName;
        } 

        public static T DeepClone<T>(T obj)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
        public void Print()
        {
            Console.WriteLine($"County : {Name} contains:");
           
            Console.WriteLine("Cities :");

            foreach (var city in cities)
            {
                Console.WriteLine($"City: {city.Name} Population: {city.Population}");
            }

            Console.WriteLine("Regions :");

            foreach (var region in regions)
            {
                Console.WriteLine($"City: {region.Name} Square: {region.Square}");
            }
        }


    }
}
