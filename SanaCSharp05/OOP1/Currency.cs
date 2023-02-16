using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Currency
    {
        protected string Name { get; set; }
        protected double ExRate { get; set; }

        public Currency() 
        {
            Name = "UAH";
            ExRate = 36.9;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
            ExRate = 1;
        }

        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
    }
}
