using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP1.Display;

namespace OOP1
{
    public class Currency
    {
        protected string _name = "Euro";
        public string Name {
            set {
                if (value != null && value != "") 
                _name = value; 
            }
            get { return _name; } 
        }

        protected double _exRate = 40.21;
        public double ExRate {
            set { 
                if (value>=0.001)
                    _exRate = value;
            }
            get { return _exRate;} 
        }

        public Currency()
        {

        }
        public Currency(Currency currency)
        {
            _name = currency.Name;
            _exRate = currency.ExRate;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
        }
    }
}
