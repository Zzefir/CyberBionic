using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set in dollar exchange rate: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Set in euro exchange rate: ");
            double eur = Convert.ToDouble(Console.ReadLine());
            Console.Write("Set in rubl exchange rate: ");
            double rub = Convert.ToDouble(Console.ReadLine());

            Converter money = new Converter(usd, eur, rub);

            Console.WriteLine("UAH: ");
            double uah = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose currency: usd, eur, rub");
            string currency = Console.ReadLine();

            if (currency == "usd")
            {
                Console.WriteLine("{0} usd", uah / money.Usd);
            }
            else if (currency == "eur")
            {
                Console.WriteLine("{0} eur", uah/money.Eur);
            }
            else if (currency == "rub")
            {
                Console.WriteLine("{0} rub", uah/money.Rub);
            }
            else
            {
                Console.WriteLine("There is no such currency");
            }

            Console.ReadKey();
        }
    }
}
