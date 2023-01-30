using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { if (!string.IsNullOrEmpty(value)) name = value; }
        }
        private decimal exRate;
        public decimal ExRate
        {
            get { return exRate; }
            set { exRate = value; }
        }
        public Currency() { }
        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
        public Currency(string name, decimal exRate) : this(exRate)
        {
            Name = name;
        }
        public Currency(decimal exRate)
        {
            ExRate = exRate;
        }
    }
}
