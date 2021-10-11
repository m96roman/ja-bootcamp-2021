namespace Task4
{
    public class DbResult<T>
    {
        public bool IsSucceded { get; set; }
        public T Value { get; set; }

        public DbResult(bool isSucceded, T value)
        {
            IsSucceded = isSucceded;
            Value = value;
        }

        public override string ToString()
        {
            return $"Value {Value} is succeded? {IsSucceded}";
        }
    }
}
