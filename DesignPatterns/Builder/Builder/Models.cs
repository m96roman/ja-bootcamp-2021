using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Models
    {
        public List<object> _model = new List<object>();

        public void Build(string spares)
        {
            _model.Add(spares);
        }
    }
}
