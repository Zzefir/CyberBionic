using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double payment = 0d;
            double tax = 0d;
            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            Console.Write("Write your surname: ");
            string surname = Console.ReadLine();

            Employee worker = new Employee(name, surname);

            Console.Write("Write your experience: ");
            worker.SetExperience = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write your position: worker, engeneer, boss ");
            worker.SetPosition = Console.ReadLine();

            if (worker.GetPosition == "worker")
            {
                if (worker.GetExperience < 10)
                {
                    tax = 3 * 300 / 100;
                    payment = 300 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
                if (worker.GetExperience >= 10 && worker.GetExperience <20)
                {
                    tax = 4 * 300 / 100;
                    payment = 300 + 30*300/100 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
                if (worker.GetExperience >= 20)
                {
                    tax = 6 * 300 / 100;
                    payment = 300 + 70*300/100 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
            }
            else if (worker.GetPosition == "engeneer")
            {
                if (worker.GetExperience < 10)
                {
                    tax = 3 * 400 / 100;
                    payment = 400 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
                if (worker.GetExperience >= 10 && worker.GetExperience < 20)
                {
                    tax = 4 * 400 / 100;
                    payment = 400 + 30 * 400 / 100 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
                if (worker.GetExperience >= 20)
                {
                    tax = 6 * 400 / 100;
                    payment = 400 + 70 * 400 / 100 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
            }
            else if (worker.GetPosition == "boss")
            {
                if (worker.GetExperience < 10)
                {
                    tax = 3 * 1000 / 100;
                    payment = 1000 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
                if (worker.GetExperience >= 10 && worker.GetExperience < 20)
                {
                    tax = 4 * 1000 / 100;
                    payment = 1000 + 30 * 1000 / 100 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
                if (worker.GetExperience >= 20)
                {
                    tax = 6 * 1000 / 100;
                    payment = 1000 + 70 * 1000 / 100 - tax;

                    worker.Show();
                    Console.WriteLine("Your payment is {0}$", payment);
                    Console.WriteLine("Your tax is {0}$", tax);
                }
            }

            else { Console.WriteLine("There is no such position!"); }

            Console.ReadKey();
        }
    }
}
