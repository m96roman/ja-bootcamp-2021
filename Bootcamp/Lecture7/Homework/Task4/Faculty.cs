using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public struct Faculty
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
