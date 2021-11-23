namespace Tailor_AbstractFactory
{
    interface ITailorDepartment
    {
        string SewBack();

        string SewFront();

        string SewLeft();

        string SewRight();

        IClothes CreateClothes();
    }
}
