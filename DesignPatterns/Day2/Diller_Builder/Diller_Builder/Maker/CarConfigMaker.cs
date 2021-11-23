using Diller_Builder.Config;

namespace Diller_Builder.Maker
{
    class CarConfigMaker : ICarMaker
    {
        public void GetBasic(ICarDistributor builder)
        {
            System.Console.WriteLine("Building basic..");
            builder.BuidEngine(engineCapacity: 1.5);
            builder.BuidDisks(discksDiameter: 15);
        }

        public void GetPremium(ICarDistributor builder)
        {
            System.Console.WriteLine("Building premium..");
            builder.BuidEngine(engineCapacity: 1.8);
            builder.BuidDisks(discksDiameter: 16);
        }

        public void GetSuperMega(ICarDistributor builder)
        {
            System.Console.WriteLine("Building super mega..");
            builder.BuidEngine(engineCapacity: 1.81);
            builder.BuidDisks(discksDiameter: 16);
            builder.BuildHeater(hasHeater: true);
        }
    }
}
