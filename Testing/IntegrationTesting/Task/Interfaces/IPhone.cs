using Task.Enums;

namespace Task.Interfaces
{
    public  interface IPhone
    {
        int BatteryLevel { get; set; }
        string PhoneName { get; set; }
        PhoneType Type { get; set; }
        ILogger _Logger { get; set; }

        void CallAmbulance();
        void Charge();
        void ChargeABit();
    }
}
