using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Abstraction_Interface.AbstractClass;      //Digunakan apabila menggunakan Abstract Class
using Abstraction_Interface.Interface;            //Digunakan apabila menggunakan Interface
namespace Abstraction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbsTabung tabung;  //Digunakan apabila menggunakan Abstract Class
            ITabung tabung;   //Digunakan apabila menggunakan Interface

            Console.WriteLine("Volume Tabung");
            tabung.volume();

            Console.ReadKey(true);
        }
    }
}
