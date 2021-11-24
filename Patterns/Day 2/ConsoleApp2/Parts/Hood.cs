using System;

namespace ConsoleApp2.Parts
{
    public class Hood : JacketPart
    {
        public override void Sew()
        {
            Console.Write("sew hood of model *");
        }
    }
}
