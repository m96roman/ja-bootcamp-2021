using Task.Interfaces;
using Task.Enums;

namespace TestTask.Interfaces
{
    interface IPhoneFactory
    {
        IPhone CreatePhone(PhoneType type, string namePhone, int batteryLevel, ILogger logger);
    }
}
