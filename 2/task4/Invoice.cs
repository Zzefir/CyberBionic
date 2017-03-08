using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;

        public string Article { set; get; }
        public int Quantity { set; get; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
    }
}
