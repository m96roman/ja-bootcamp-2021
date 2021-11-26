using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FlyweightFactory(
               new Build[] { 
                   new Build { _HouseType = HouseType.BrickHouse, _FlourCount = "5", _Adress = "Korzo 5" },
                   new Build { _HouseType = HouseType.MonolithicHouse, _FlourCount = "9", _Adress = "Korzo 6" },
                   new Build { _HouseType = HouseType.MonolithicHouse, _FlourCount = "20", _Adress = "Korzo 11" },
                   new Build { _HouseType = HouseType.PrefabricatedHouse, _FlourCount = "6", _Adress = "Korzo 9" },
                   new Build { _HouseType = HouseType.MonolithicHouse, _FlourCount = "9", _Adress = "Korzo 12" }
               }
            );

            factory.listFlyweights();

            addBuildToStreet(factory,new Build() {_HouseType= HouseType.BrickHouse,_FlourCount="4",_Adress="Korzo 7" });

            addBuildToStreet(factory, new Build() { _HouseType = HouseType.BrickHouse, _FlourCount = "4", _Adress = "Korzo 7" });
            factory.listFlyweights();

        }

        public static void addBuildToStreet(FlyweightFactory factory, Build build)
        {
            var flyweight = factory.GetFlyweight(new Build
            {
                _HouseType = build._HouseType,
                _FlourCount = build._FlourCount,
                _Adress = build._Adress,

            }) ;                       
        }
    }
}
