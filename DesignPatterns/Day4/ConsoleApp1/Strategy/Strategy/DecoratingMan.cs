using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class DecoratingMan
    {
        private IDecoration _decoration;

        public DecoratingMan(IDecoration decoration)
        {
            _decoration = decoration;
        }

        public void DecorateWalls()
        {
            _decoration.DecorateWalls();
        }
    }
}
