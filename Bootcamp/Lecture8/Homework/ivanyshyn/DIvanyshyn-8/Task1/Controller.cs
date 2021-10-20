namespace DIvanyshyn_8.AssembliesExample
{
    internal abstract class Controller
    {
        protected ILogger Logger { get; }

        protected Controller(ILogger logger)
        {
            Logger = logger;
        }

        public abstract int Get();

        public abstract void Post();

        public abstract void Put();

        public abstract void Delete();
    }
}