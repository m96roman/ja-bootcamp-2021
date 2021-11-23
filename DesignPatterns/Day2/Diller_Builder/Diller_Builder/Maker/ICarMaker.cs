using Diller_Builder.Config;

namespace Diller_Builder.Maker
{
    interface ICarMaker
    {
        void GetBasic(ICarDistributor builder);
        void GetPremium(ICarDistributor builder);
        void GetSuperMega(ICarDistributor builder);
    }
}