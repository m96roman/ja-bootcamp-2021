namespace YaroslavB_Linq
{
    class Student
    {
        public int StudentId { get; }
        public int FacultyId { get; }
        public string FirstName { get; }
        public double AverageGrade { get; }

        public override string ToString()
        {
            return $"StudentId: {StudentId}, FacultyId: {FacultyId}, FirstName: {FirstName}, AverageGrade: {AverageGrade}";
        }

        public Student(int studentId, int facultyId, string firstName, double averageGrade)
        {
            StudentId = studentId;
            FacultyId = facultyId;
            FirstName = firstName;
            AverageGrade = averageGrade;
        }
    }
}
