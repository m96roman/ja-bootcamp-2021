using System;

namespace Task4_Strategy
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ApartmentDesigner designer = new ApartmentDesigner();

            IExpert painter = new Painter();
            IExpert stuccoExpert = new StuccoMaster();
            IExpert wallPaperExpert = new WallpaperExpert();


            designer.UpdateDesignInRoom("corridor", painter);
            designer.UpdateDesignInRoom("kitchen", stuccoExpert);
            designer.UpdateDesignInRoom("living room", wallPaperExpert);
            designer.UpdateDesignInRoom("bedroom", painter);

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
