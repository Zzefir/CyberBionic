using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Veichle
    {
        public float x, y, z;
        public int price, speed, year;

        public Veichle(float x, float y, float z, int price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
    }
}
