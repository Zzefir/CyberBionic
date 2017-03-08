using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship sh = new Ship(2.3f, 3.4f, 8.2f, 1321, 22, 2017, 554, "Dnipro");
            sh.ShowShip();

            Plane pl = new Plane(4.2f, 5.5f, 11.7f, 333, 431, 2015, 44, 12345);
            pl.ShowPlane();

            Car cr = new Car(2.1f, 6.6f, 9.9f, 947, 80, 2010);
            cr.ShowCar();

            Console.ReadKey();
        }
    }
}
