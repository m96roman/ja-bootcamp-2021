using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   public interface ApplicationContext<T>
   {
       List<T> ExecuteSql(string sql);
   }
}
