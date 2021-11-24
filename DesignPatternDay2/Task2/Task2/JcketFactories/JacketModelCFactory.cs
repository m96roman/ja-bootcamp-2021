using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.JacketModelC;

namespace Task2.JcketFactories
{
    class JacketModelCFactory : AbstractJacketFactory
    {
        public override HoodC CreateHood()
        {
            HoodC hoodC = new HoodC();
            hoodC.MakeHood();
            return hoodC;
        }
        public override SleeveC CreateSleeve()
        {
            SleeveC sleeveC = new SleeveC();
            sleeveC.MakeSleeve();
            return sleeveC;
        }
        public override FrontPartC CreateFrontPart()
        {
            FrontPartC frontPartC = new FrontPartC();
            frontPartC.MakeFrontPart();
            return frontPartC;
        }
    }
}
