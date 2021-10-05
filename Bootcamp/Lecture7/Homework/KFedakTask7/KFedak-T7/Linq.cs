using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_T7
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public double AverageGrade { get; set; }
        public int FacultyID { get; set; }

        public override string ToString()
            => (StudentID, StudentName, AverageGrade, FacultyID).ToString();
    }

    public class Faculty
    {
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }
    }

    public static class Linq
    {
        private static IReadOnlyCollection<Student> Students { get; } = new List<Student>
    {
        new Student() { StudentID = 1, StudentName = "John", AverageGrade = 4, FacultyID = 1 } ,
        new Student() { StudentID = 2, StudentName = "John",  AverageGrade = 3, FacultyID = 1 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  AverageGrade = 5, FacultyID = 2 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , AverageGrade = 5, FacultyID = 3 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , AverageGrade = 5, FacultyID = 3 }
    };

        private static IReadOnlyCollection<Faculty> Facultys { get; } = new List<Faculty>
    {
        new Faculty(){ FacultyID = 1, FacultyName="Faculty 1"},
        new Faculty(){ FacultyID = 2, FacultyName="Faculty 2"},
        new Faculty(){ FacultyID = 3, FacultyName="Faculty 3"}
    };

        public static void StudentsWithMaxGradePerFaculty()
        {
            var innerJoin = Students.Join(// outer sequence 
                      Facultys,  // inner sequence 
                      student => student.FacultyID,    // outerKeySelector
                      standard => standard.FacultyID,  // innerKeySelector
                      (student, standard) => new  // result selector
                      {
                          StudentName = student.StudentName,
                          FacultyName = standard.FacultyName,
                          FacultyID = standard.FacultyID,
                          AverageGrade = student.AverageGrade
                      }).ToList();

            var students = (from e in innerJoin
                            group e by e.FacultyID into sgrp
                            let max = sgrp.Max(score => score.AverageGrade)
                            select new
                            {
                                FacultyID = sgrp.Key,
                                StudentName = string.Join(",", sgrp.Where(y => y.AverageGrade == max).Select(z => z.StudentName).ToList()),
                                Score = string.Join(",", sgrp.Where(y => y.AverageGrade == max).Select(z => z.AverageGrade).ToList()),
                                FacultyName = sgrp.First(y => y.AverageGrade == max).FacultyName,

                            }).ToList();

            foreach (var st in students)
            {
                Console.WriteLine("Student {0} and {1}", st.StudentName, st.FacultyName);
            }
        }

        public static void SameName()
        {
            var students = (from e in Students
                            group e by e.StudentName into sgrp
                            let count = sgrp.Count()
                            orderby count descending
                            select new
                            {
                                StudentName = sgrp.Key,
                                Count = count
                            }).ToList();

            foreach (var st in students)
            {
                Console.WriteLine("Student {0} - count:{1}", st.StudentName, st.Count);
            }
        }

        public static void SameNamePerFaculty()
        {
            //var innerJoin = Students.Join(// outer sequence 
            //          Facultys,  // inner sequence 
            //          student => student.FacultyID,    // outerKeySelector
            //          standard => standard.FacultyID,  // innerKeySelector
            //          (student, standard) => new  // result selector
            //          {
            //              StudentName = student.StudentName,
            //              FacultyName = standard.FacultyName,
            //              FacultyID = standard.FacultyID,
            //              AverageGrade = student.AverageGrade
            //          }).ToList();

            //var students = (from e in innerJoin
            //                group e by e.StudentName into sgrp
            //                let count = sgrp.Count()
            //                orderby count descending
            //                select new
            //                {
            //                    StudentName = sgrp.Key,
            //                    Count = count
            //                }).ToList();

            //var query = (from c in Facultys
            //                     join o in Students on  c.FacultyID equals o.FacultyID
            //                     group o by o.FacultyID into g
            //                     select new
            //                     {
            //                         FacultyID = g.Key,
            //                         Count = g.Where(z=>z.FacultyID==g.Key).Select(x => x.StudentName).Distinct().Count(),
            //                     }).OrderByDescending(y => y.Count);

            //foreach (var st in query)
            //{
            //    Console.WriteLine("Faculty {0} - count:{1}", st.FacultyID, st.Count);
            //}
        }

        public static void PrintObjects(this IEnumerable<object> students)
    => students.ToList().ForEach(s => Console.WriteLine(s));

    }
}
