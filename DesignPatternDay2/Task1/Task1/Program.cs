using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractOfficeFactory domesticOffice = new OfficeCreatorFactory();
            domesticOffice.DeliverAllGoods();
        }
    }
}
