namespace Task2_Decorator
{
    class PCDecorator : IPC
    {
        private IPC _basePC;

        public PCDecorator(IPC basePC)
        {
            _basePC = basePC;
        }

        public virtual void AssembleSystemBlock()
        {
            _basePC.AssembleSystemBlock();
        }

        public virtual void SetAccessories()
        {
            _basePC.SetAccessories();
        }

        public virtual void SetMonitor()
        {
            _basePC.SetMonitor();
        }
    }
}
