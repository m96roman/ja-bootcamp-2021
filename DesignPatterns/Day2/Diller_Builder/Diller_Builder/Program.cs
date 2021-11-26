using Diller_Builder.Config;
using Diller_Builder.Maker;

namespace Diller_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoSalon autoSalon = new AutoSalon();

            autoSalon.BuildCar(typeof(CarConfigMaker), typeof(A2Distributor), ConfigType.Premium);
            autoSalon.BuildCar(typeof(CarConfigMaker), typeof(A1Distributor), ConfigType.SuperMega);
            autoSalon.BuildCar(typeof(CarConfigMaker), typeof(A3Distributor), ConfigType.Basic);
        }
    }
}
