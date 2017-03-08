using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Car : Veichle
    {
        public Car(float x, float y, float z, int price, int speed, int year)
            :base(x, y, z, price, speed, year)
        {

        }

        public void ShowCar()
        {
            Console.WriteLine("CAR: coordinates are: ({0}, {1}, {2}); price is: {3}; speed is {4}, year is: {5}", this.x, this.y, this.z, this.price, this.speed, this.year);
        }
    }
}
