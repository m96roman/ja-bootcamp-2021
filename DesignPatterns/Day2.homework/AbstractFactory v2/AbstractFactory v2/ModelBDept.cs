using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_v2
{
    class ModelBDept : IModelFactory
    {
        private Clothes _clothes;

        public IBack MakeBack()
        {
            _clothes.Back = "Make back for model B";
            return _clothes;
        }

        public ICollar MakeCollar()
        {
            _clothes.Collar = "Make colar for model B";
            return _clothes;
        }

        public IFront MakeFront()
        {
            _clothes.Front = "Make front for model B";
            return _clothes;
        }

        public IHood MakeHood()
        {
            _clothes.Hood = "Make back for model B";
            return _clothes;
        }
    }
}
