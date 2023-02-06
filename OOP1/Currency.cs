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
        public float ExRate { get; set; }
        public Currency()
        {
            Name = "UAH";
            ExRate = 1;
        }
        public Currency(string name, float exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(string name)
        {
            Name = name;
            ExRate = 1;
        }
        public Currency(float exRate)
        {
            Name = "";
            ExRate = exRate;
        }
        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
    }
}
