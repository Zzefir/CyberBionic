using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(2, 2, "A"), new Point(3,3,"B"), new Point(4,4,"C"));

            figure.PerimetrCalculator();

            Console.ReadKey();
        }
    }
}
