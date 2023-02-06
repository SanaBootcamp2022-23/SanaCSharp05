using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Classes
{
    public class Currency
    {
        private string name;
        private float exRate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float ExRate
        {
            get { return exRate; }
            set { exRate = value; }
        }
        public Currency(string name, float exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
        public Currency(string name)
        {
            Name = name;
            ExRate = 0;
        }
        public Currency(float exRate)
        {
            Name = string.Empty;
            ExRate = exRate;
        }
        public Currency()
        {
            Name = string.Empty;
            ExRate = 0;
        }
    }
}
