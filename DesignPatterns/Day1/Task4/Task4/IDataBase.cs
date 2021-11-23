using System.Collections.Generic;

namespace Task4
{
    public interface IDataBase
    {
        List<T> GetModel<T>();
    }
}
