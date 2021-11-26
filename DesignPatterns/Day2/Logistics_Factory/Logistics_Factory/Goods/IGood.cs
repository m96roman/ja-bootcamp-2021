namespace Goods
{
    public interface IGood
    {
        string Name { get; set; }
    }
    public class Stone : IGood
    {
        public string Name { get; set; }
    }
}