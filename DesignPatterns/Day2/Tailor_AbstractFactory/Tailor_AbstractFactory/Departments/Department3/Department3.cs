using System;

namespace Tailor_AbstractFactory
{
    public class Department3 : ITailorDepartment
    {
        IBack ITailorDepartment.SewBack()
        {
            return new Back3();
        }

        IFront ITailorDepartment.SewFront()
        {
            return new Front3();
        }

        ILeft ITailorDepartment.SewLeft()
        {
            return new Left3();
        }

        IRight ITailorDepartment.SewRight()
        {
            return new Right3();
        }
    }
}
