using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public interface ISqlDb
    {
        List<T> ExecuteSql<T>(string sql);

    }
}
