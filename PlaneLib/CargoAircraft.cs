using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneLib
{
    public class CargoAircraft : IPlane
    {
        public string type { get; set; }
        public string destination { get; set; }
        public int wingspan { get; set; }
        public string airline { get; set; }
        public int maxheight { get; set; }
        public int maxspeed { get; set; }
        public int speed { get; set; }
        public void changespeed(int speedc)
        {
            this.speed = speedc;
        }
        public int payload { get; set; }

    }
}

