namespace Task3
{
    public interface IGreetingSender
    {
        string PostIndex { get; set; }
        string Street { get; set; }
        string City { get; set; }
        string Country { get; set; }

        void SendGreeting(string v);
    }
}