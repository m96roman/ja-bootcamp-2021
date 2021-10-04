using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    class TaskExample
    {
        public void Task4()
        {
            DomesticPackage domesticPackage = new DomesticPackage(22.5, "Aliexpress", "Shyptur Yevhen", 2478);
            ForeignPackage foreignPackage = new ForeignPackage(1.2, "Next.ua", "Shyptur Yevhen", "England");

            var newdelivery = new NovaPoshtaDelivery();
            newdelivery.DeliverPackage(domesticPackage);

            var newdelivery2 = new MeestExpressDelivery();
            newdelivery2.DeliverPackage(foreignPackage);
        }
        public void Task3()
        {
            DataReader dataReader = new DataReader();
            DbResult<List<string>> dbListString = dataReader.GetCityNames();
            for (int i = 0; i < dbListString.Value.Count; i++)
            {
                Console.WriteLine(dbListString.IsSucceded + " - " + dbListString.Value[i]);
            }
            DbResult<int> dbInt = dataReader.GetMagicNumber();
            Console.WriteLine(dbInt.IsSucceded.ToString() + "     " + dbInt.Value.ToString());
        }
        public void Task2()
        {
            Dictionary<string, List<Person>> peopleA = new Dictionary<string, List<Person>>();
            Random rnd = new Random();
            string[] city = { "Kiev", "Uzh", "Lviv", "Ivano-Fr", "Moskow" };

            for (int i = 0; i < 1000; i++)
            {
                int numberofcity = rnd.Next(city.Length);
                string cityString = city[numberofcity];
                if (peopleA.ContainsKey(cityString))
                {
                    peopleA[cityString].Add(new Person("Name" + i));
                }
                else
                {
                    peopleA.Add(cityString, new List<Person> { new Person("Name" + i) });
                }
            }
            foreach (var item in peopleA)
            {
                Console.WriteLine(item.Key + "  -   " + item.Value.Count);
            }
        }
    }
}
