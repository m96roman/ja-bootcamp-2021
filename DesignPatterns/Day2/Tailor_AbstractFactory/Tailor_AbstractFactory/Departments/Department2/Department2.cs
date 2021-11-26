using System;

namespace Tailor_AbstractFactory.Department_2
{
    public class Department2 : ITailorDepartment
    {
        IBack ITailorDepartment.SewBack()
        {
            return new Back2();
        }

        IFront ITailorDepartment.SewFront()
        {
            return new Front2();
        }

        ILeft ITailorDepartment.SewLeft()
        {
            return new Left2();
        }

        IRight ITailorDepartment.SewRight()
        {
            return new Right2();
        }
    }
}
