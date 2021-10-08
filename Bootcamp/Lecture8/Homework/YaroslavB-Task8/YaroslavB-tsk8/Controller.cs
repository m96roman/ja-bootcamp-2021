using System;

namespace YaroslavB_tsk8
{
    class Controller
    {
        private int _stateValue = 8;

        public Controller(string name)
        {
            Name = name;
        }

        public string Name { get; }

        [Route("/controller/get")]
        public int Get()
        {
            return _stateValue;
        }

        [Route("/controller/post")]
        public void Post()
        {
            Console.WriteLine($"Post method executed in {Name} controller");
        }

        [Route("/controller/put")]
        public void Put()
        {
            Console.WriteLine($"Put method executed in {Name} controller");
        }

        [Route("/controller/delete")]
        public void Delete()
        {
            Console.WriteLine($"Delete method executed in {Name} controller");
        }
    }
}
