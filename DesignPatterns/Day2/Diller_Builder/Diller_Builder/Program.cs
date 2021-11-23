using Diller_Builder.Config;
using Diller_Builder.Maker;
using System;

namespace Diller_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoSalon autoSalon = new AutoSalon();

            autoSalon.BuildCar(typeof(CarConfigMaker), typeof(A2Distributor), ConfigType.Premium);
            autoSalon.BuildCar(typeof(CarConfigMaker), typeof(A1Distributor), ConfigType.SuperMega);
        }
    }
    class AutoSalon
    {
        public void BuildCar(Type carMakerType, Type distributorType, ConfigType configType = ConfigType.Basic)
        {
            var maker = (ICarMaker)Activator.CreateInstance(carMakerType);
            var distributor = (ICarDistributor)Activator.CreateInstance(distributorType);

            switch (configType)
            {
                case ConfigType.Basic:
                    maker.GetBasic(distributor);
                    break;
                case ConfigType.Premium:
                    maker.GetPremium(distributor);
                    break;
                case ConfigType.SuperMega:
                    maker.GetSuperMega(distributor);
                    break;
                default:
                    Console.WriteLine("What?");
                    break;
            }

            Console.WriteLine("auto " + distributor.GetModel().GetType().Name + " " + configType);
        }
    }

    internal enum ConfigType
    {
        Basic,
        Premium,
        SuperMega
    }
}
