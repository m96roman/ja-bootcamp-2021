namespace Task3
{
    //This class does so much thing in once..
    public class Person : IPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public string Power { get; set; }

        public string Alias { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
