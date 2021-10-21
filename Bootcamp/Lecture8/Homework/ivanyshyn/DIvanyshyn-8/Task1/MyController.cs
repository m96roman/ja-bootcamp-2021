using System;

namespace DIvanyshyn_8.AssembliesExample
{
    //Servlet)0)
    [Route(name: "controller")]
    class MyController : Controller
    {
        public MyController(ILogger logger) : base(logger)
        {
        }

        [Route(name: "delete")]
        public override ActionResult Delete()
        {
            Logger.Log("Method Delete in MyController is called");
            return new ActionResult("Method Delete in MyController is called");
        }

        [Route(name: "get")]
        public override ActionResult Get()
        {
            Logger.Log("Method Get in MyController is called");
            return new ActionResult(8);
        }

        [Route(name: "post")]
        public override ActionResult Post()
        {
            Logger.Log("Method Post in MyController is called");
            return new ActionResult("Method Post in MyController is called");
        }

        [Route(name: "put")]
        public override ActionResult Put()
        {
            Logger.Log("Method Put in MyController is called");
            return new ActionResult("Method Put in MyController is called");
        }
    }
}