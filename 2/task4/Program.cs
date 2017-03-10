using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(132414, "Samsung", "Rozetka");

            inv.Article = "phone";
            inv.Quantity = 3;

            inv.Cost(false);

            Console.ReadKey();
        }
    }
}
