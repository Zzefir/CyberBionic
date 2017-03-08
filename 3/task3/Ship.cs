using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Ship:Veichle
    {
        public int passengers;
        public string port;

        public Ship(float x, float y, float z, int price, int speed, int year, int passengers, string port)
            :base(x, y, z, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        public void ShowShip()
        {
            Console.WriteLine("SHIP: coordinates are: ({0}, {1}, {2}); price is: {3}; speed is {4}, year is: {5}; passengers: {6}, port is: {7}", this.x, this.y, this.z, this.price, this.speed, this.year, this.passengers, this.port);
        }
    }
}
