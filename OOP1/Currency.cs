using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        private string Name;
        private float ExRate;
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
