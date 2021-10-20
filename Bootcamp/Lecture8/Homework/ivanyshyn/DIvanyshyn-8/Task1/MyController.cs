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
            Console.WriteLine("Thank god i deleting");
        }

        [Route(name: "get")]
        public override int Get()
        {
            return 8;
        }

        [Route(name: "post")]
        public override void Post()
        {
            Console.WriteLine("Thank god i posting");
        }

        [Route(name: "put")]
        public override void Put()
        {
            Console.WriteLine("Thank god i putting");
        }
    }
}