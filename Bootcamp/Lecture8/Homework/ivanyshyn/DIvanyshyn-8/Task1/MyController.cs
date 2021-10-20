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
        public override void Delete()
        {
            Logger.Log("Thank god i deleting");
        }

        [Route(name: "get")]
        public override int Get()
        {
            return 8;
        }

        [Route(name: "post")]
        public override void Post()
        {
            Logger.Log("Thank god i posting");
        }

        [Route(name: "put")]
        public override void Put()
        {
            Logger.Log("Thank god i putting");
        }
    }
}