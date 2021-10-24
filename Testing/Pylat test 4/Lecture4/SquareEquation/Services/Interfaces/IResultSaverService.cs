using System;
using System.Collections.Generic;
using System.Text;

namespace SquareEquation
{
    public interface IResultSaverService
    {
        bool Save(List<double> list, string filePath);
    }
}
