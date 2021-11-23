using System;

namespace Task3
{
    public class Hero : ISalary, IAccount
    {
        public string Alias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Power { get; set; }      
        public Gender Gender { get; set; }
        public Adderess Adderess { get; }
        public Account FinAccount { get; set; }

        public Hero(Adderess address)
        {
            Adderess = address;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
