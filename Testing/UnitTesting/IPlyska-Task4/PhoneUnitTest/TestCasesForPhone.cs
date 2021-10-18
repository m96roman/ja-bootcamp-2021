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
        /// Test case for testing value for propperty BatteryLevel
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

    }
}
