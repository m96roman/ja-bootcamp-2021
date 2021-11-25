using System;
using System.Collections.Generic;
using ConsoleApp6.Enums;
using ConsoleApp6.Abstracts;
using ConsoleApp6.Houses;

namespace ConsoleApp6
{
    public class HouseFactory
    {
        public Dictionary<Tuple<Floors, TypeHouse>, House> houses = new Dictionary<Tuple<Floors, TypeHouse>, House>();

        public HouseFactory()
        {
            // brick houses
            houses.Add(new Tuple<Floors, TypeHouse>(Floors.Five, TypeHouse.Brick), new BrickHouse { FloorAmount = Floors.Five, Type = TypeHouse.Brick });

            // monolit houses
            houses.Add(new Tuple<Floors, TypeHouse>(Floors.Nine, TypeHouse.Monolit), new MonolitHouse { FloorAmount = Floors.Nine, Type = TypeHouse.Monolit });
            houses.Add(new Tuple<Floors, TypeHouse>(Floors.Twenty, TypeHouse.Monolit), new MonolitHouse { FloorAmount = Floors.Twenty, Type = TypeHouse.Monolit });

            //panel houses
            houses.Add(new Tuple<Floors, TypeHouse>(Floors.Six, TypeHouse.Panel), new PanelHouse { FloorAmount = Floors.Six, Type = TypeHouse.Panel });
            houses.Add(new Tuple<Floors, TypeHouse>(Floors.Nine, TypeHouse.Panel), new PanelHouse { FloorAmount = Floors.Nine, Type = TypeHouse.Panel });
        }

        public House GetHouse(Tuple<Floors, TypeHouse> key)
        {
            if (houses.ContainsKey(key))
            {
                return houses[key];
            }
            else
            {
                return null;
            }
        }
    }
}
