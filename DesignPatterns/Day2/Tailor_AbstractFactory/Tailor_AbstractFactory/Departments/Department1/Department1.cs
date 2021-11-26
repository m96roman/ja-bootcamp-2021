using System;

namespace Tailor_AbstractFactory
{
    public class Department1 : ITailorDepartment
    {
        IBack ITailorDepartment.SewBack()
        {
            return new Back1();
        }

        IFront ITailorDepartment.SewFront()
        {
            return new Front1();
        }

        ILeft ITailorDepartment.SewLeft()
        {
            return new Left1();
        }

        IRight ITailorDepartment.SewRight()
        {
            return new Right1();
        }
    }
}
