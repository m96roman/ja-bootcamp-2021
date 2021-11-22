using System.Collections.Generic;

namespace Task4
{
    //Because IRepository<teacher> is repository too
    public interface IRepository<T>
    {
        List<T> GetEntities();
    }
}