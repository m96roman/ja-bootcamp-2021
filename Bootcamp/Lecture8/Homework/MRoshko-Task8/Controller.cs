using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task8
{
    public class Controller
    {
        public string Name { get; set; }

        [Route("/controller/get")]
        public int Get() 
        {
            return 8;    
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
            Console.WriteLine($"Delete method execute in {Name} controller");
        }
    }
}
