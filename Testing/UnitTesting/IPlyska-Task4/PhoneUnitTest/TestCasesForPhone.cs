using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPlyskaLect4;

namespace PhoneUnitTest
{
    public class TestCasesForPhone
    {
        Phone phone;
       public TestCasesForPhone()
       {
            phone = new Phone();
       }

        /// <summary>
        /// Test Case for testing Charge method in class Phone
        /// </summary>
         public void TestCasePhoneCharge(int batteryLevel)
         {
            phone.BatteryLevel = batteryLevel;
            phone.Charge();

            if (phone.BatteryLevel != 100)
            {
                Console.WriteLine($"Test case 'TestCasePhoneCharge' is FAILED!!!");
                Console.WriteLine($"Actual result is {phone.BatteryLevel}  expected result is 100");
            }
            else
            {
                Console.WriteLine($"Test case 'TestCasePhoneCharge' is PASSED!!!");
                Console.WriteLine($"Actual result is {phone.BatteryLevel}  expected result is 100");
            }
         }

        /// <summary>
        /// Test case for testing value for propperty BatteryLevel
        /// in class Phone more than 100
        /// </summary>
         public void TestCaseBatteryLevelMore100(int batteryLevel)
         {
            try
            {
                phone.BatteryLevel = batteryLevel;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test case 'TestCaseBatteryLevelMore100' is PASSED");
                return;
            }
            
            if (phone.BatteryLevel >= 100 && phone.BatteryLevel >= 0)
            {
                Console.WriteLine("Test case 'TestCaseBatteryLevelMore100' is PASSED");
                return;
            }

            Console.WriteLine("Test case 'TestCaseBatteryLevelMore100' is FAILED");
         }

        /// <summary>
        /// Test case for testing value for property BatteryLevel
        /// in class Phone less than 0
        /// </summary>
         public void TestCaseBatteryLevelLess0(int  batteryLevel)
         {
            try
            { 
                phone.BatteryLevel = batteryLevel;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test case 'TestCaseBatteryLevelLess0' is PASSED");
                return;
            }

            Console.WriteLine("Test case 'TestCaseBatteryLevelLess0' is FAILED");
         }

        /// <summary>
        /// Test Case for testing Charge method in class Phone
        /// </summary>
        public void TestCaseChargeABit(int batteryLevel)
        {
            string message = $"Charging {phone.GetType().Name} by 1%";
            phone.BatteryLevel = batteryLevel;
            var expectedResult = batteryLevel + 1;

            phone.ChargeABit();

            if (expectedResult != phone.BatteryLevel || Loger.messages.Last() != message)
            {
                Console.WriteLine("Test case 'TestCaseChargeABit' is FAILED");
            }
            else
            {
                Console.WriteLine("Test case 'TestCaseChargeABit' is PASSED");
            }
        }

        /// <summary>
        /// Test Case for testing CallAmbulance method in class Phone
        /// when BatteryLevel more than 5
        /// </summary>
        public void TestCaseCallAmbulanceMoreThan5(int batteryLevel)
        {   
            phone.BatteryLevel = batteryLevel;
            var expectedResult = batteryLevel - 5;

            phone.CallAmbulance();

            string message = $"calling an ambulance from {phone.GetType().Name}, remaining charge: {phone.BatteryLevel}%";

            if (phone.BatteryLevel != expectedResult || Loger.messages.Last() != message)
            {
                Console.WriteLine("Test case 'TestCaseCallAmbulanceMoreThan5' is FAILED");
            }
            else
            {
                Console.WriteLine("Test case 'TestCaseCallAmbulanceMoreThan5' is PASSED");
            }
        }

        /// <summary>
        /// Test Case for testing CallAmbulance method in class Phone
        /// when BatteryLevel less than 5
        /// </summary>
        public void TestCaseCallAmbulanceLessThan5(int batteryLevel)
        {
           
            var expectedValue = batteryLevel - 5;
            try
            {
                phone.BatteryLevel = batteryLevel;
                phone.CallAmbulance();

            }
            catch (Exception ex)
            {
                if (phone.BatteryLevel == 0 )
                {
                    Console.WriteLine("Test case 'TestCaseCallAmbulanceLessThan5' is PASSED");
                    return;
                }
            }
            if (phone.BatteryLevel == expectedValue )
            {
                Console.WriteLine("Test case 'TestCaseCallAmbulanceLessThan5' is PASSED");
                return;
            }

            Console.WriteLine("Test case 'TestCaseCallAmbulanceLessThan5' is FAILED");
        }

        /// <summary>
        /// Test Case for testing PrayForBattery method 
        /// </summary>
        public void TestCasePrayForBattery(int batteryLevel)
        {
            Nokia nokia = new Nokia();
            var expectedResult = batteryLevel + 8;
            nokia.BatteryLevel = batteryLevel;

            const string message = "praying for the battery";

            nokia.PrayForBattery();
            if (nokia.BatteryLevel != expectedResult && Loger.messages.Last().ToString() != message)
            {
                Console.WriteLine("Test case 'TestCasePrayForBattery' is FAILED");
            }
            else
            {
                Console.WriteLine("Test case 'TestCasePrayForBattery' is PASSED");
            }
        }


    }
}
