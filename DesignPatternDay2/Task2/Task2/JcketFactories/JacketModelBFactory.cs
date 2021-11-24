using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.JcketFactories
{
    class JacketModelBFactory : AbstractJacketFactory
    {
        public override HoodB CreateHood()
        {
            HoodB hoodB = new HoodB();
            hoodB.MakeHood();
            return hoodB;
        }
        public override SleeveB CreateSleeve()
        {
            SleeveB sleeveB = new SleeveB();
            sleeveB.MakeSleeve();
            return sleeveB;
        }
        public override FrontPartB CreateFrontPart()
        {
            FrontPartB frontPartB = new FrontPartB();
            frontPartB.MakeFrontPart();
            return frontPartB;
        }
    }
}
