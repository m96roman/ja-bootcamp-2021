namespace Strategy
{
    class ClassMason : IMason
    {
        private IOperation operation;

        public void ExecuteOpertion(string message)
        {
            this.operation.Execute(message);
        }

        public void SetOperation(IOperation operation)
        {
            this.operation = operation;
        }
    }
}