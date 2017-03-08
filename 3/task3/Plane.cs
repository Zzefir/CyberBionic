using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Plane:Veichle
    {
        public int high, passengers;

        public Plane(float x, float y, float z, int price, int speed, int year, int passengers, int high)
            :base(x, y, z, price, speed, year)
        {
            this.passengers = passengers;
            this.high = high;
        }

        public void ShowPlane()
        {
            Console.WriteLine("PLANE: coordinates are: ({0}, {1}, {2}); price is: {3}; speed is {4}, year is: {5}; passengers: {6}, high is: {7}", this.x, this.y, this.z, this.price, this.speed, this.year, this.passengers, this.high);
        }
    }
}
