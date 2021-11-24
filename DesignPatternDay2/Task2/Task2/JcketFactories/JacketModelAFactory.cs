using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.JcketFactories
{
    class JacketModelAFactory: AbstractJacketFactory
    {
        public override HoodA CreateHood() 
        {
            HoodA hoodA = new HoodA();
            hoodA.MakeHood();
            return hoodA;
        }
        public override SleeveA CreateSleeve()
        {
            SleeveA sleeveA = new SleeveA();
            sleeveA.MakeSleeve();
            return sleeveA;
        }
        public override FrontPartA CreateFrontPart()
        {
            FrontPartA frontPartA = new FrontPartA();
            frontPartA.MakeFrontPart();
            return frontPartA;
        }
    }
}
