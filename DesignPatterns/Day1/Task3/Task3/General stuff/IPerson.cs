namespace Task3
{
    public interface IPerson
    {
        string LastName { get; set; }
        string FirstName { get; set; }

        string GetFullName();
    }
}