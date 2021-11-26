using System.Collections.Generic;

namespace ConsoleApp4.Interfaces
{
    public interface IMySqlDb
    {
        List<T> ExecuteSql<T>(string sql);
    }
}
