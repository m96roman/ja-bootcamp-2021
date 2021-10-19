using Task;
using Task.Interfaces;

namespace TestTask
{
    internal static class TestData
    {
        public static IPhone phoneIPhone13 = new Iphone13
        {
            PhoneName = "IPhone 13 Test 1",
            BatteryLevel = 14,
            Type = PhoneTypes.IphoneType
        };
        public static Nokia nokiaPhone = new Nokia
        {
            PhoneName = "Nokia 3110 Test 2",
            BatteryLevel = 18,
            Type = PhoneTypes.NokiaType
        };
        public static IPhone phoneIPhone13ZeroBattery = new Iphone13
        {
            PhoneName = "IPhone 13 Test 1",
            BatteryLevel = 0,
            Type = PhoneTypes.IphoneType
        };
        public static Nokia nokiaPhoneZeroBattery = new Nokia
        {
            PhoneName = "Nokia 3110 Test 2",
            BatteryLevel = 0,
            Type = PhoneTypes.NokiaType
        };
        public static IPhone phoneIPhone13More5Battery = new Iphone13
        {
            PhoneName = "IPhone 13 Test 1",
            BatteryLevel = 0,
            Type = PhoneTypes.IphoneType
        };
        public static Nokia nokiaPhoneMore5Battery = new Nokia
        {
            PhoneName = "Nokia 3110 Test 2",
            BatteryLevel = 0,
            Type = PhoneTypes.NokiaType
        };
    }
}
