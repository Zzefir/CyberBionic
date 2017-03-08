using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Converter
    {
        double usd, eur, rub;

        public Converter (double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double Usd
        {
            get { return usd; }
        }

        public double Eur
        {
            get { return eur; }
        }

        public double Rub
        {
            get { return rub; }
        }
      
    }
}
