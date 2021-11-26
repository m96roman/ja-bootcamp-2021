using Diller_Builder.Config;
using Models;

namespace Diller_Builder.Maker
{
    interface ICarMaker
    {
        ICarModel GetBasic(ICarDistributor builder);
        ICarModel GetPremium(ICarDistributor builder);
        ICarModel GetSuperMega(ICarDistributor builder);
    }
}