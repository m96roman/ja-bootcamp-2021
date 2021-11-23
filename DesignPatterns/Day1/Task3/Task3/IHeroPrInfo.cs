namespace Task3
{
    public interface IHeroPrInfo
    {
        string City { get; set; }
        string Country { get; set; }
        string PostIndex { get; set; }
        string Street { get; set; }

        void SendGreeting(string text);
    }
}