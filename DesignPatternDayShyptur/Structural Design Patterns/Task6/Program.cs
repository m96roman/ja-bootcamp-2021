using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseCity city = new HouseCity();
            city.AddStreet("Shevchenka");
            city.AddHouseInStreet("Shevchenka", 1, new PanelHouse(6));
            city.AddHouseInStreet("Shevchenka", 10, new PanelHouse(9));
            
        }
    }
}
