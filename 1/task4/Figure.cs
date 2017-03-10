using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Figure
    {
        Random rnd = new Random();
        Point[] points = new Point[5];
        double length;

        public Figure (Point po0, Point po1, Point po2)
        {
            this.points[0] = po0;
            this.points[1] = po1;
            this.points[2] = po2;
            this.points[3] = new Point();
            this.points[4] = new Point();
        }

        public Figure(Point po0, Point po1, Point po2, Point po3)
        {
            this.points[0] = po0;
            this.points[1] = po1;
            this.points[2] = po2;
            this.points[3] = po3;
            this.points[4] = new Point();
        }
        public Figure(Point po0, Point po1, Point po2, Point po3, Point po4)
        {
            this.points[0] = po0;
            this.points[1] = po1;
            this.points[2] = po2;
            this.points[3] = po3;
            this.points[4] = po4;
        }

        public double LengthSide (Point A, Point B)
        {
            length = Math.Sqrt(Math.Pow(B.Field1 - A.Field1, 2d) + Math.Pow(B.Field2 - A.Field2, 2d));
            return length;
        }

        public void PerimetrCalculator()
        {
            double sum = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += LengthSide(points[i], points[i + 1]);
            }

            sum += LengthSide(points[points.Length-1], points[0]);

            Console.WriteLine("Perimetr = {0}", sum);
        }
    }
}
