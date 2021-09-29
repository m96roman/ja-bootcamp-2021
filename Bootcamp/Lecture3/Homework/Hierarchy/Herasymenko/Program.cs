using System;

namespace Herasymenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                },
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                },
                new Manager
                {
                    FirstName = "Manager",
                    LastName = "Managerov",
                }
            };

            foreach(var person in persons)
            {
                if (person is Manager)
                {
                    person.SoftSkills.Skills = "soft";
                    person.SoftSkills.PrintSkills();
                }
                person.PrintFullName();
                person.PrintPersonAge();

            }
        }
    }

    public static class Company
    {
        public const string JUNIOR_POSITION_NAME = "junior";
        public const string MIDDLE_POSITION_NAME = "middle";
        public const string SENIOR_POSITION_NAME = "senior";
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private readonly int _age;
        public SoftSkills SoftSkills { get; set; } = new SoftSkills();
        public CodeSkills CodeSkills { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            _age = age;
            
        }

        public Person() : this (null, null, 25)
        {

        }

        public virtual void PrintFullName()
        {
            Console.WriteLine($"Person FullName is: {FirstName} { LastName}");
        }

        public void PrintPersonAge()
        {
            Console.WriteLine($"Person age is: {_age}");
        }
    }

    public class Employee : Person
    {
        public string Position => _position;
       
        protected string _position = Company.MIDDLE_POSITION_NAME;

        public Employee(string position) : base()
        {
            _position = position;
        }

        public Employee() : base() { }

        public override void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine($"The position of this person is: { Position }");
        }
    }

    public class Manager : Employee
    {
        public Manager() : base(Company.SENIOR_POSITION_NAME)
        {

        }
    }

    public abstract class SkillSet
    {
        public virtual string Skills { get; set; }

        public abstract void PrintSkills();

        public SkillSet(string skills)
        {
            Skills = skills;
        }
    }

    public class SoftSkills : SkillSet
    {
        public override string Skills { get => base.Skills; }

        public SoftSkills(string skill) : base(skill) { }
        public SoftSkills() : this(null) { }

        public override void PrintSkills()
        {
            Console.WriteLine($"This person has {Skills} skill");
        }
    }

    public class CodeSkills : SkillSet
    {
        public override string Skills { get => base.Skills; }

        public CodeSkills(string skill) : base(skill) { }

        public CodeSkills() : this(null) { }

        public override void PrintSkills()
        {
            Console.WriteLine($"This person has {Skills} skill");
        }
    }
}
