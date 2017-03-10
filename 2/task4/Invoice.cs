using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer, provider;
        string article;
        int quantity;

        public string Article { set; get; }
        public int Quantity { set; get; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        
        public void Cost(bool NDS)
        {
            double cost;
             switch (Article)
            {
                case "laptop": cost = 1313;
                    break;
                case "tablet": cost = 666;
                    break;
                case "phone": cost = 300;
                    break;
                default: Console.WriteLine("There is no such loot");
                    return;
            }
            if (NDS)
            {
                cost = cost - cost * 7 / 100;
            }

            Console.WriteLine("Order sum = {0}$", cost*Quantity);
        }
    }
}
