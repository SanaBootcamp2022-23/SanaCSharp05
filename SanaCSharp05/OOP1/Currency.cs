using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        protected string Name;
        protected double ExRate;
        public string name
        {
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Name = value;
                }
            }
            get { return Name; }
        }
        public double exRate
        {
            set 
            {
                if (value > 0)
                {
                    ExRate = value;
                }
            }
            get { return ExRate; }
        }

        public Currency()
        {
            Name = "No Data";
            ExRate = 0.00;
        }
        public Currency(string name, double exRate) : this(exRate)
        {
            Name = name;
        }
        public Currency (double exRate)
        {
            ExRate = exRate;
        }
        public Currency(Currency currency) : this(currency.Name, currency.ExRate)
        {

        }
    }
}
