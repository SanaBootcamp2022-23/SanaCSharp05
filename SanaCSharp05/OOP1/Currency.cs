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
            set { name = value; }
            get { return name; }
        }

        private double exrate;
        public double ExRate
        {
            set { exrate = value; }
            get { return exrate; }
        }

        public Currency()
        { 
        }

        public Currency(string Name , double currency)
        {
            name = Name;
            exrate = currency;
        }

        public Currency(Currency currency)
        {
            name = currency.name;
            exrate = currency.exrate;
        }
    }
}
