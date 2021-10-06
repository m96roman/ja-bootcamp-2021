namespace DIvanyshyn_8.AssembliesExample
{
    [Route(name: "controllerA")]
    class MyControllerA : Controller
    {
        [Route(name: "delete")]
        public override void Delete()
        {
            System.Console.WriteLine("Controller2 is unique and very good deleter");
        }

        [Route(name: "get")]
        public override int Get()
        {
            System.Console.WriteLine("Controller2 is unique and very good getter");
            return 440;
        }

        [Route(name: "post")]
        public override void Post()
        {
            System.Console.WriteLine("Controller2 is unique and very good poster");
        }

        [Route(name: "put")]
        public override void Put()
        {
            System.Console.WriteLine("Controller2 is unique and very good putter");
        }
    }
}