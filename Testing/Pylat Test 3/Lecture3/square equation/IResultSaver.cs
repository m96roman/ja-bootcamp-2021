using System;
using System.Collections.Generic;
using System.Text;

namespace square_equation
{
    public interface IResultSaver
    {
        bool SaveResult(List<double> list, string filePath);
    }
}
