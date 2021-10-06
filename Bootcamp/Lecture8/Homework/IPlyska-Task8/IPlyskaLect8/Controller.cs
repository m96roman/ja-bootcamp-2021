using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect8
{
    public class Controller
    {
        public string Name { get; set; }

        [Route("/controller/get")]
        int Get() => 8;

        [Route("/controller/post")]
        void Post() => Console.WriteLine($"Post method executed in {Name} controller");

        [Route("/controller/put")]
        void Put() => Console.WriteLine($"Put method executed in {Name} controller");

        [Route("/controller/delete")]
        void Delete() => Console.WriteLine($"Delete method execute in {Name} controller");
    }
}
