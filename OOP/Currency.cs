using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Currency
    {
        protected string Name = "NoName";
        public decimal ExRate = 0;
        public Currency()
        {
            Name = "NoName";
            ExRate = 0;
        }
        public Currency(string name, decimal exRate)
        {
            Name = name;    
            ExRate = exRate;
        }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency(decimal exRate)
        {
            ExRate = exRate;
        }
        public Currency(Currency obj)
        {
            Name=obj.Name;
            ExRate = obj.ExRate;
        }
        public override string ToString()
        {
            return $"Ім'я Currency {Name}\nПеревод в грн{ExRate}";
        }
        public void SetNameCurrency(string name) { Name = name; }
        public void SetExRate(decimal exRate) { ExRate = exRate; }

        public string GetNameCurrency() { return Name; }
        public decimal GetExRate() { return ExRate; }
    }
}

