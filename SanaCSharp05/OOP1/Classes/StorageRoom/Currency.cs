using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Classes.StorageRoom
{
    public class Currency
    {
        protected string name = "EUR";
        protected decimal exRate = 40.36M;

        public string Name { get => name;
            set {
                if (value.Length > 0)
                    name = value;
            } 
        }
        public decimal ExRate { get => exRate;
            set {
                if (value > 0)
                    exRate = value;
            } 
        }

        public Currency() { }
        public Currency(string Name)
        {
            this.Name = Name;
        }
        public Currency(string Name, decimal ExRate) : this(Name)
        {

            this.ExRate = ExRate;
        }
        public Currency(Currency currency): this(currency.Name, currency.ExRate) { }

        public override string ToString()
        {
            return $"Назва валюти - {Name} \tКурс - {ExRate}";
        }
    }
}
