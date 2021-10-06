namespace DIvanyshyn_7.Task4
{
    class Student
    {
        public Student(int studentId, int facultyId, string firstName, int averageGrade)
        {
            StudentId = studentId;
            FacultyId = facultyId;
            FirstName = firstName;
            AverageGrade = averageGrade;
        }

        public int StudentId { get; init; }

        public int FacultyId { get; set; }

        public string FirstName { get; set; }

        public int AverageGrade { get; set; }

        public override string ToString()
        {
            return (StudentId, FacultyId, FirstName, AverageGrade).ToString();
        }
    }
}
