using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    public class Currency
    {
        protected string _name = "USD";
        protected double _exRate = 40;

        public Currency() { }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency(string name, double exrate)
        {
            Name = name;
            ExRate = exrate;
        }
        public Currency(Currency currency) : this(currency.Name, currency.ExRate)
        {

        }
        public string Name
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
            get
            {
                return _name;
            }
        }
        public double ExRate
        {
            set
            {
                if (value > 0)
                {
                    _exRate = value;
                }
            }
            get
            {
                return _exRate;
            }
        }
    }
}
