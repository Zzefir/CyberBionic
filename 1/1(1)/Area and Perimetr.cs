using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("set in 2 numbers:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(side1, side2);
            rect.AreaCalculator();
            rect.PerimetrCalculator();
            Console.WriteLine("perimetr = {0}", rect.Perimetr);
            Console.WriteLine("area = {0}", rect.Area);
            Console.ReadKey();
        }
    }
}
