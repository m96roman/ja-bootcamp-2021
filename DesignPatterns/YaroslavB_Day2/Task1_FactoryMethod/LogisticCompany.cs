namespace Task1_FactoryMethod
{
    abstract class LogisticCompany
    {
        private ILogger _logger;

        public LogisticCompany() : this(new ConsoleLogger()) { }

        public LogisticCompany(ILogger logger)
        {
            _logger = logger;
        }

        public void Deliver(string address, string goods)
        {
            ITransport transport = DefineTransport();
            string status = transport.Deliver(address, goods);
            _logger.Log(status);
        }
        
        protected abstract ITransport DefineTransport();
    }
}
