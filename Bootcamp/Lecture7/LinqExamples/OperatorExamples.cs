using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

    public int StandardID { get; set; }

    public override string ToString()
        => (StudentID, StudentName, Age, StandardID).ToString();
}

public class Standard
{
    public int StandardID { get; set; }
    public string StandardName { get; set; }
}

public static class OperatorExamples
{
    private static IReadOnlyCollection<Student> Students { get; } = new List<Student>
    {
        new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID = 1 } ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID = 1 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 15, StandardID = 2 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21, StandardID = 3 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15, StandardID = 3 }
    };

    private static IReadOnlyCollection<Standard> Standards { get; } = new List<Standard>
    {
        new Standard(){ StandardID = 1, StandardName="Standard 1"},
        new Standard(){ StandardID = 2, StandardName="Standard 2"},
        new Standard(){ StandardID = 3, StandardName="Standard 3"}
    };

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID &&
                        x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }

    public static void WhereExample()
    {
        Students.Where(s => s.Age > 12 && s.Age < 20).PrintObjects();
        Students.Where(s => s.Age > 12).Where(s => s.Age < 20).PrintObjects();
        Students.Where((s, i) => s.Age > 12 && i < 2).PrintObjects(); // prints 2 first students;
    }

    public static void OfTypeAndCastExample()
    {
        var list = new List<object> { 8, "someElement", 99, "anotherElement" };

        // only strings are returned
        var onlyStrings = list.OfType<string>().ToList();
        
        // throws InvalidCastException
        var castString = list.Cast<string>().ToList(); 
    }

    public static void SortingOperatorExample()
    {
        Students.OrderBy(s => s.StudentName).PrintObjects();
        Students.OrderBy(s => s.StudentName).ThenBy(s => s.Age).PrintObjects();

        Students.OrderBy(s => s.StudentName).Reverse().PrintObjects();
        Students.OrderByDescending(s => s.StudentName).PrintObjects(); // the same result as line above
        Students.OrderByDescending(s => s.StudentName).ThenByDescending(s => s.Age).PrintObjects();
    }

    public static void GroupingExample()
    {
        var groupedResult = Students.GroupBy(s => s.Age);

        foreach (var ageGroup in groupedResult)
        {
            Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

            foreach (Student s in ageGroup)  //Each group has a inner collection  
                Console.WriteLine("Student Name: {0}", s.StudentName);
        }
    }

    public static void SelectExample()
    {
        var projected = Students.Select(s => new { s.Age, s.StudentName });

        var groupedProjected = projected.GroupBy(s => s.Age);

        projected.PrintObjects();
        // Select many flattens collection of collections into single collection
        groupedProjected.SelectMany(group => group.ToList()).PrintObjects();
    }

    public static void JoinExample()
    {
        var innerJoin = Students.Join(// outer sequence 
                      Standards,  // inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                      {
                          StudentName = student.StudentName,
                          StandardName = standard.StandardName
                      });
        innerJoin.PrintObjects();
    }

    public static void GroupJoinExample()
    {
        var groupJoin = Standards.GroupJoin(Students,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.StandardID,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

        foreach (var item in groupJoin)
        {
            Console.WriteLine(item.StandarFulldName);

            foreach (var stud in item.Students)
                Console.WriteLine(stud.StudentName);
        }
    }

    public static void QuatifierOperators()
    {
        // checks whether all the students are teenagers    
        bool areAllStudentsTeenAger = Students.All(s => s.Age > 12 && s.Age < 20);
        // checks whether any of the students are teenagers   
        bool isAnyStudentTeenAger = Students.Any(s => s.Age > 12 && s.Age < 20);

        var emptyCollection = new List<int>();
        emptyCollection.Any(); // returns false;
        emptyCollection.All(i => i > 0); // returns true;

    }

    public static void PrintObjects(this IEnumerable<object> students)
        => students.ToList().ForEach(s => Console.WriteLine(s));
}
