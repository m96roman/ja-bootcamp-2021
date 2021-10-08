namespace YaroslavB_Linq
{
    class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }

        public Faculty(int facultyId, string name)
        {
            FacultyId = facultyId;
            Name = name;
        }
    }
}
