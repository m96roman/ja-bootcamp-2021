namespace DIvanyshyn_8.AssembliesExample
{
    internal abstract class Controller
    {
        protected ILogger Logger { get; }

        protected Controller(ILogger logger)
        {
            Logger = logger;
        }

        public abstract ActionResult Get();

        public abstract ActionResult Post();

        public abstract ActionResult Put();

        public abstract ActionResult Delete();
    }
}