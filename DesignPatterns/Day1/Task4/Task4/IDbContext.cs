using System.Collections.Generic;

namespace Task4
{
    public interface IDbContext<T>
    {
        List<T> ExecuteSql(string sql);
    }
}