using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        protected string name;
        protected decimal exRate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal ExRate
        {
            get { return exRate; }
            set { exRate = value; }
        }

        public Currency(string name, decimal exRate)
        {
            Name = name;
            ExRate = exRate;

        }

        public Currency()
        {
            Name = "Dollar";
            ExRate = 40.4m;
        }

        public Currency(Currency otherCurrency)
        {
            Name = otherCurrency.name;
            ExRate = otherCurrency.exRate;
        }

    }

}
