using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalSetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            User us = new User();

            Console.WriteLine("Write your name:");
            us.SetName = Console.ReadLine();
            Console.WriteLine("write your surname:");
            us.SetSurname = Console.ReadLine();
            Console.WriteLine("write your login");
            us.SetLogin = Console.ReadLine();
            Console.WriteLine("write your age:");
            us.SetAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", us.GetName, us.GetSurname, us.GetLogin, us.GetAge, us.GetDate);

            Console.ReadKey();
        }
    }
}
