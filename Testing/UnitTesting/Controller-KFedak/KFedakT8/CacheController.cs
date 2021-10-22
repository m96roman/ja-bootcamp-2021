using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakT8
{
    public class CacheController
    {
        public string Name { get; set; }

        [Route(Name = "/controller/get")]
        public int Get()
        {
            return 8;
        }

        [Route(Name = "/controller/post")]
        public string Post()
        {
            return $"Post method executed in {Name} controller";
        }

        [Route(Name = "/controller/put")]
        public string Put()
        {
            return $"Put method executed in {Name} controller";
        }

        [Route(Name = "/controller/delete")]
        public string Delete()
        {
            return $"Delete method execute in {Name} controller";
        }
    }
}
