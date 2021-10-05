namespace YaroslavB_Task5
{
    class DbResult<T>
    {
        public bool IsSucceded { get; }
        public T Value { get; }

        public DbResult(T value, bool status)
        {
            IsSucceded = status;
            Value = value;
        }
    }
}
