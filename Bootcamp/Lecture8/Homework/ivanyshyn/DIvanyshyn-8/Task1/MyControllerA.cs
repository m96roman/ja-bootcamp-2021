namespace DIvanyshyn_8.AssembliesExample
{
    [Route(name: "controllerA")]
    class MyControllerA : Controller
    {
        public MyControllerA(ILogger logger) : base(logger)
        {
        }

        [Route(name: "delete")]
        public override void Delete()
        {
            Logger.Log("Controller2 is unique and very good deleter");
        }

        [Route(name: "get")]
        public override int Get()
        {
            Logger.Log("Controller2 is unique and very good getter");
            return 440;
        }

        [Route(name: "post")]
        public override void Post()
        {
            Logger.Log("Controller2 is unique and very good poster");
        }

        [Route(name: "put")]
        public override void Put()
        {
            Logger.Log("Controller2 is unique and very good putter");
        }
    }
}