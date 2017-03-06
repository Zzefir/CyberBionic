using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_
{
    class Rectangle
    {
        public double side1, side2;
        double area;
        double perimetr;

        public Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            area = this.side1 * this.side2;
            return area;
        }

        public double PerimetrCalculator()
        {
            perimetr = 2*this.side1 + 2*this.side2;
            return perimetr;
        }
        
        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Perimetr
        {
            get
            {
                return perimetr;
            }
        }
    }
}
