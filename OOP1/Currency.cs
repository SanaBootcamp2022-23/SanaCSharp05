using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        public string Name { get; set; }
        public double ExRate { get; set; }
        public Currency()
        {
            Name = "Hryvnia";
            ExRate = 36.75;
        }

        public Currency(string name, double exRate)        
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
        }

        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }        
    }
}
