namespace Tailor_AbstractFactory
{
    interface ITailorDepartment
    {
        IBack SewBack();

        IFront SewFront();

        ILeft SewLeft();

        IRight SewRight();
    }
}
