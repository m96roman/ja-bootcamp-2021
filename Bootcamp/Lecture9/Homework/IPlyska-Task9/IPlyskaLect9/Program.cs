using IPlyskaLect4;
using System;
using System.Collections.Generic;

namespace IPlyskaLect9
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileWorker.ReadFromConsole();

            //List<Student> students = Student.DeSerialize();
            //if (students.Count == 0)
            //{
            //    students = new List<Student>
            //    {
            //       new Student { LecturesAttended = 1, Name = "Ivan"},
            //       new Student { LecturesAttended = 3, Name = "Max"},
            //       new Student { LecturesAttended = 4, Name = "Loki"},
            //       new Student { LecturesAttended = 6, Name = "Thor"},
            //       new Student { LecturesAttended = 7, Name = "Vika"},
            //       new Student { LecturesAttended = 18, Name = "Ivan"},
            //    };
            //}

            //Student.SemesterEmulation(students);
            //Student.SerializeStudents(students);

            List<Phone> container = new List<Phone>()
            {
                new Nokia{BatteryLevel = 5},
                new IPhone13{BatteryLevel = 10},
                new Nokia{BatteryLevel = 25},
                new IPhone13{BatteryLevel = 8},
                new Nokia{BatteryLevel = 12}
            };

            PhoneEmergencyTestHolder phone = new PhoneEmergencyTestHolder(container);
            int counter = 1;
            while (counter != 10)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(phone);
                }
                catch (BatteryIsDeadException ex)
                {
                    Logger.WriteLine(ex.ToString());
                    ex.phone.Charge();
                }

                counter++;
            }

            Console.ReadLine();

        }
    }
}
