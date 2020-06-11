using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface.Interface;
{
    interface VolTabung : ITabung
    {
        double phi = 3.14;
        double r = 7;
        double = 20;

        public void volume()
        {
            Console.WriteLine("Volume tabung = " + (phi * r * r * t));
        }
    }
}
