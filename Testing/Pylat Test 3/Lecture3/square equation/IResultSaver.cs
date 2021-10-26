using System;
using System.Collections.Generic;
using System.Text;

namespace square_equation
{
    public interface IResultSaver
    {
        void SaveResult(List<double> list, string filePath);
    }
}
