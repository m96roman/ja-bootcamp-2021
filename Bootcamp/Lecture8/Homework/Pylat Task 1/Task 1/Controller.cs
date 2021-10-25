using System;

namespace Task_1
{
    public class Controller
    {
        public string Name { get;set; }

        [Route(Name = "/controller/get")]
        public int Get()
        {
            return 8;
        }

        [Route(Name = "/controller/post")]
        public string Post()
        {
            Console.WriteLine($"Post method executed in {Name}controller");
            return $"Post method executed in {Name}controller";
        }

        [Route(Name = "/controller/put")]
        public string Put()
        {
            Console.WriteLine($"Put method executed in {Name}controller");
            return $"Put method executed in {Name}controller";
        }

        [Route(Name = "/controller/delete")]
        public string Delete()
        {
            Console.WriteLine($"Delete method execute in {Name}controller");
            return $"Delete method executed in {Name}controller";
        }
    }
}
