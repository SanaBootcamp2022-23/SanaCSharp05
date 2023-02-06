using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        protected string Name = "Unknown";
        protected decimal ExRate = 0;
        public Currency() { }
        public Currency(string name, decimal exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
        public void PrintFullCurrency()
        {
            Console.WriteLine($"Currency: {Name} with rate {ExRate}");
        }
        public string GetNameCurrency()
        {
            return Name;
        }
        public decimal GetExRate()
        {
            return ExRate;
        }
        public void SetNameCurrency(string nameCurrency)
        {
            Name = nameCurrency;
        }
        public void SetExRate(decimal exRate)
        {
            ExRate = exRate;
        }
    }
}
