using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Currency
    {
        protected string name = "Unknown";
        protected double exRate = 0;
        public string Name { get { return name; } set {if (value.Length > 0) name = value; } }
        public double ExRate { get { return exRate; } set { if (value > 0) exRate = value; } }

        public Currency()
        {

        }

        public Currency(double currencyExRate)
        {
            ExRate = currencyExRate;
        }

        public Currency(string currencyName, double currencyExRate) : this(currencyExRate)
        {
            Name = currencyName;
        }

        public Currency(Currency currency)
            : this(currency.Name, currency.ExRate)
        {

        }
    }
}
