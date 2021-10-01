namespace DIvanyshyn_5.Task_3
{
    class DbResult<T>
    {
        public bool IsSucced { get; private set; }

        public T Value { get; private set; }

        public DbResult(bool isSucced, T value)
        {
            IsSucced = isSucced;
            Value = value;
        }

        public override string ToString()
        {
            return $"Value {Value} get result was {IsSucced}";
        }
    }
}
