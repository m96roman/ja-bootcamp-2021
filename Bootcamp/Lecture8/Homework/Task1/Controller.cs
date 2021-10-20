using System;
using Task1.Attributes;

namespace Task1
{
    public class Controller
    {
        public string Name { get; set; }

        [Route(Name = "/controller/get")]
        public int Get()
        {
            return 8;
        }

        [Route(Name = "/controller/post")]
        public void Post()
        {
            Console.WriteLine($"Post method executed in {Name} controller");
        }

        [Route(Name = "/controller/put")]
        public void Put()
        {
            Console.WriteLine($"Put method executed in {Name} controller");
        }

        [Route(Name = "/controller/delete")]
        public void Delete()
        {
            Console.WriteLine($"Delete method execute in {Name} controller");
        }
    }
}
