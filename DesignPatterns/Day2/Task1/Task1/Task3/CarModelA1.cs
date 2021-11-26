using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class CarModelA1 : ICarComponents
    {
        private Product _product = new Product();

        public void DiametrWheels(int diametr)
        {
            _product.Add(diametr.ToString());
        }

        public void Engine(double engine)
        {
            _product.Add(engine.ToString());
        }

        public void heatedSeats(bool value)
        {
            _product.Add(value.ToString());
        }
        public Product GetProduct()
        {           
            return _product;
        }

        public string GetModelCar()
        {
            return "Its A1 ";
        }
    }
}
