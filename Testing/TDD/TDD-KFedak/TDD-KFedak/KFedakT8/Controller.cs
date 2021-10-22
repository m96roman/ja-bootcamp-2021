using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakT8
{
    public class Controller
    {
        public string Name { get; set; }

        public ILogger Logger { get; set; }

        [Route(Name = "/controller/get")]
        public int Get()
        {
            return 8;
        }

        [Route(Name = "/controller/post")]
        public void Post()
        {
           Logger.WriteLine($"Post method execute in {Name} controller");
        }

        [Route(Name = "/controller/put")]
        public void Put()
        {
            Logger.WriteLine($"Put method execute in {Name} controller");
        }

        [Route(Name = "/controller/delete")]
        public void Delete()
        {
            Logger.WriteLine($"Delete method execute in {Name} controller");
        }

    }
}
