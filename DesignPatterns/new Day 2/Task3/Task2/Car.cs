using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Car
    {
        public Engine Engine { get; set; }
        // соль
        public Warm Warm { get; set; }
        // пищевые добавки
        public Disks Disks { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Engine != null)
                sb.Append(Engine.Capasity + "\n");
            if (Warm != null)
                sb.Append("Seats Warm \n");
            if (Disks != null)
                sb.Append("Disks size: " + Disks.Size + " \n");
            return sb.ToString();
        }
    }
}
