namespace DIvanyshyn_8.AssembliesExample
{
    [Route(name: "/controllerA")]
    class MyController2 : Controller
    {
        [Route(name: "/delete")]
        public override void Delete()
        {
            throw new System.NotImplementedException();
        }
        [Route(name: "/get")]
        public override int Get()
        {
            return 440;
        }
        [Route(name: "/post")]
        public override void Post()
        {
            throw new System.NotImplementedException();
        }
        [Route(name: "/put")]
        public override void Put()
        {
            throw new System.NotImplementedException();
        }
    }
}