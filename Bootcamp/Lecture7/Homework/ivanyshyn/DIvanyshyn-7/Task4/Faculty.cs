﻿namespace DIvanyshyn_7.Task3
{
    class Faculty
    {
        public Faculty(int facultyId, string name)
        {
            FacultyId = facultyId;
            Name = name;
        }

        public int FacultyId { get; init; }

        public string Name { get; set; }
    }
}
