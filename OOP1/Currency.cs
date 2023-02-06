using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        public string Name { get; set; } = "Unknown currency";
        public double ExRate { get; set; } = 35;
        public Currency()
        {

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
