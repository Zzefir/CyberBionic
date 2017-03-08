using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Write your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Write your login");
            string login = Console.ReadLine();
            Console.WriteLine("Write your age");
            int age = Convert.ToInt32(Console.ReadLine());

            User us = new User(name, surname, login, age);

            us.Show();

            Console.ReadKey();
        }
    }
}
