using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneLib
{
    public interface IPlane
    {
        string type { get; set; }
        string destination { get; set; }
        int wingspan { get; set; }
        string airline { get; set; }
        int maxheight { get; set; }
        int maxspeed { get; set; }
        int speed { get; set; }
        void changespeed(int speedc);

    }
}