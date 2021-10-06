using System;

namespace DIvanyshyn_8.AssembliesExample
{
    //Servlet)0)
    [Route(name: "/controller")]
    class MyController : Controller
    {
        [Route(name: "/delete")]
        public override void Delete()
        {
            Console.WriteLine("Thank god i deleting");
        }

        [Route(name: "/get")]
        public override int Get()
        {
            return 50;
        }

        [Route(name: "/post")]
        public override void Post()
        {
            Console.WriteLine("Thank god i posting");
        }

        [Route(name: "/put")]
        public override void Put()
        {
            Console.WriteLine("Thank god i putting");
        }
    }
}