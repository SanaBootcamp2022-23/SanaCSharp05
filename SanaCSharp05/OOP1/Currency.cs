using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        protected string name;
        protected double exRate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double ExRate
        {
            get { return exRate; }
            set { exRate = value; }
        }

        public Currency() { }

        public Currency(string name)
        {
            Name = name;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
    }
}
