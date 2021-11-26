using Diller_Builder.Config;
using Models;

namespace Diller_Builder.Maker
{
    class CarConfigMaker : ICarMaker
    {
        public ICarModel GetBasic(ICarDistributor builder)
        {
            System.Console.WriteLine("Building basic..");
            builder.BuidEngine(engineCapacity: 1.5);
            builder.BuidDisks(discksDiameter: 15);

            return ReturnModel(builder);
        }

        private static ICarModel ReturnModel(ICarDistributor builder)
        {
            var entity = builder.GetModel();

            builder.Reset();

            return entity;
        }

        public ICarModel GetPremium(ICarDistributor builder)
        {
            System.Console.WriteLine("Building premium..");
            builder.BuidEngine(engineCapacity: 1.8);
            builder.BuidDisks(discksDiameter: 16);

            return ReturnModel(builder);
        }

        public ICarModel GetSuperMega(ICarDistributor builder)
        {
            System.Console.WriteLine("Building super mega..");
            builder.BuidEngine(engineCapacity: 1.81);
            builder.BuidDisks(discksDiameter: 16);
            builder.BuildHeater(hasHeater: true);

            return ReturnModel(builder);
        }
    }
}
