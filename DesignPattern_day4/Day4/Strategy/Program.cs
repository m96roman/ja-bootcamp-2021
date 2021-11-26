using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Expert master = new Expert(new Plaster());
            master.SetMethodDecor();
            master.SetStrategy(new Draw());
            master.SetMethodDecor();
        }
    }
}
