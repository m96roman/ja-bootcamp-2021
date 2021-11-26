using Diller_Builder.Config;
using Diller_Builder.Maker;
using Models;
using System;

namespace Diller_Builder
{
    class AutoSalon
    {
        public ICarModel BuildCar(Type carMakerType, Type distributorType, ConfigType configType = ConfigType.Basic)
        {
            var maker = (ICarMaker)Activator.CreateInstance(carMakerType);
            var distributor = (ICarDistributor)Activator.CreateInstance(distributorType);
            ICarModel carModel = null;

            switch (configType)
            {
                case ConfigType.Basic:
                    carModel = maker.GetBasic(distributor);
                    break;
                case ConfigType.Premium:
                    carModel = maker.GetPremium(distributor);
                    break;
                case ConfigType.SuperMega:
                    carModel = maker.GetSuperMega(distributor);
                    break;
                default:
                    Console.WriteLine("What?");
                    break;
            }

            Console.WriteLine("auto " + carModel.GetType().Name + " " + configType);

            return carModel;
        }
    }
}
