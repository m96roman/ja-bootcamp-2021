using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Interfaces
{
    public interface IMySqlDb
    {
        List<T> ExecuteSql<T>(string sql);
    }
}
