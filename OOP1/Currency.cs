using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Currency
    {
        string name = "";
        double ex_rate = 0;
        public string Name
        {
            get { return name; }
            set { if (name != "") name = value; }
        }
        public double ExRate
        {
            get { return ex_rate; }
            set { if (value > 0) ex_rate = value; }
        }

        public Currency() { }
        public Currency(string name, double ex_rate)
        {
            this.name = name;
            this.ex_rate = ex_rate;
        }
        public Currency(double ex_rate)
        {
            this.ex_rate = ex_rate;
        }
        public Currency(Currency currency) : this(currency.name,currency.ex_rate) { }


    }
}