using IPlyskaLect4;
using System;

namespace PhoneUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCasesForPhone test = new TestCasesForPhone();

            test.TestCaseBatteryLevelLess0(-1);
            test.TestCaseBatteryLevelLess0(-100);
            test.TestCaseBatteryLevelMore100(100);
            test.TestCaseBatteryLevelMore100(101);
            test.TestCaseCallAmbulanceLessThan5(4);
            test.TestCaseCallAmbulanceLessThan5(5);
            test.TestCaseCallAmbulanceMoreThan5(6);
            test.TestCaseCallAmbulanceMoreThan5(20);
            test.TestCaseChargeABit(20);
            test.TestCasePhoneCharge(4);
            test.TestCasePrayForBattery(34);
        }

       
    }
}
