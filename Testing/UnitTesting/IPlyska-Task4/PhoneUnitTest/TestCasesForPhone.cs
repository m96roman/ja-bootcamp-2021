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
         void TestCasePhoneCharge()
         {
            phone.BatteryLevel = 50;
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
         void TestCaseBatteryLevelMore100()
         {
            try
            {
                phone.Charge();
                phone.ChargeABit();
            }
            catch (Exception ex)
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
         void TestCaseBatteryLevelLess0()
         {
            try
            {
                phone.Charge();
                phone.BatteryLevel -= 101;
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
        void TestCaseChargeABit()
        {
            phone.BatteryLevel = 60;
            var expectedResult = 61;

            phone.ChargeABit();

            if (expectedResult != phone.BatteryLevel)
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
        void TestCaseCallAmbulanceMoreThan5()
        {
            phone.BatteryLevel = 5;
            var expectedResult = 0;

            phone.CallAmbulance();

            if (phone.BatteryLevel != expectedResult)
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
        void TestCaseCallAmbulanceLessThan5()
        {
            try
            {
                phone.BatteryLevel = 4;
                phone.CallAmbulance();
            }
            catch (Exception ex)
            {
                if (phone.BatteryLevel == 0)
                {
                    Console.WriteLine("Test case 'TestCaseCallAmbulanceLessThan5' is PASSED");
                    return;
                }
            }

            Console.WriteLine("Test case 'TestCaseCallAmbulanceLessThan5' is FAILED");
        }

        /// <summary>
        /// Test Case for testing PrayForBattery when 
        /// </summary>
        void TestCasePrayForBattery()
        {
            Nokia nokia = new Nokia();
            var expectedResult = 58;
            nokia.BatteryLevel = 50;

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
