
namespace MRoshko_Task5
{
    public class DbResult<T>
    {
        public bool IsSucceded { get; set; }

        public T Value { get; set; }
    }
}
