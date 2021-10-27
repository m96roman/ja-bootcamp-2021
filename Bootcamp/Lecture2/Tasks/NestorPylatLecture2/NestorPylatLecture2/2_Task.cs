using System;
using System.Collections.Generic;
using System.Text;

namespace NestorPylatLecture2
{
    struct Marker
    {
       public string color;
        public static Marker? InitMaker(string color)
        {
            if(color != null)
            {
                return new Marker(color);

            }return null;
        }
        public Marker(string color)
        {
            this.color = color;
        }
    }
    class _2_Task
    {
        public static void doTask2()
        {

          var mark=  Marker.InitMaker(null) ?? new Marker("default");
            Console.WriteLine(mark);

        }
    }
}
