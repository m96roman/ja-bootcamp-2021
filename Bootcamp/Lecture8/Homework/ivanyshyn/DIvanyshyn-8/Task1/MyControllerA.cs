namespace DIvanyshyn_8.AssembliesExample
{
    [Route(name: "controllerA")]
    class MyControllerA : Controller
    {
        public MyControllerA(ILogger logger) : base(logger)
        {
        }

        [Route(name: "delete")]
        public override ActionResult Delete()
        {
            Logger.Log("Controller2 is unique and very good deleter");
            return new ActionResult("Controller2 is unique and very good deleter");
        }

        [Route(name: "get")]
        public override ActionResult Get()
        {
            Logger.Log("Controller2 is unique and very good getter");
            return new ActionResult(440);
        }

        [Route(name: "post")]
        public override ActionResult Post()
        {
            Logger.Log("Controller2 is unique and very good poster");
            return new ActionResult("Controller2 is unique and very good poster");
        }

        [Route(name: "put")]
        public override ActionResult Put()
        {
            Logger.Log("Controller2 is unique and very good putter");
            return new ActionResult("Controller2 is unique and very good putter");
        }
    }
}