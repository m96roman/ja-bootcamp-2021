using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public interface IMySqlDb
    {
        List<T> ExecuteSql<T>(string sql);
    }
}
