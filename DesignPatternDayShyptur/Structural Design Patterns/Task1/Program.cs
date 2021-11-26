using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BirdToTransportAdapter birdToTransportAdapter = new BirdToTransportAdapter(new Dove());
            birdToTransportAdapter.Send("asfsf");  
        }
    }
}
