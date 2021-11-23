using System;

namespace Tailor_AbstractFactory
{
    public class Department3 : ITailorDepartment
    {
        public IClothes CreateClothes()
        {
            Console.WriteLine(SewBack() + " " + SewFront() + " " + SewLeft() + " " + SewRight());

            return new Jacket3();
        }

        public string SewBack()
        {
            return "sewing back";
        }

        public string SewFront()
        {
            return "sewing front";
        }

        public string SewLeft()
        {
            return "sewing left";
        }

        public string SewRight()
        {
            return "sewing right";
        }
    }
}
