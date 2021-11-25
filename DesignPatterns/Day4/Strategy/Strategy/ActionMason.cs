using System;

namespace Strategy
{
    class ActionMason : IMason
    {
        private Action<string> operation;

        public void SetOperation(Action<string> operation)
        {
            this.operation = operation;
        }

        public void ExecuteOpertion(string message)
        {
            operation.Invoke(message);
        }
    }
}
