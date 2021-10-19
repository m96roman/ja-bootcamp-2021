using Task;
using Task.Interfaces;
using Task.Enums;
using TestTask.Interfaces;

namespace TestTask
{
    class PhoneFactory : IPhoneFactory
    {
        public IPhone CreatePhone(PhoneType type, string namePhone, int batteryLevel, ILogger logger)
        {
            switch(type)
            {
                case PhoneType.IPhone:
                    return new Iphone13(namePhone, batteryLevel, type, logger);
                case PhoneType.Nokia:
                    return new Nokia(namePhone, batteryLevel, type, logger);
                default:
                    return new Iphone13(namePhone, batteryLevel, type, logger);
            }
        }
    }
}
