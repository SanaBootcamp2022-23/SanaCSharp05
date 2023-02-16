using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        protected string name;
        protected double exRate;
        public Currency()
        {
            name = "UAH";
            exRate = 1;
        }
        public Currency(string Name, double ExRate)
        {
            name = Name;
            exRate = ExRate;
        }
        public Currency(string Name)
        {
            name = Name;
            exRate = 39.95;
        }
        public Currency(Currency obj) : this(obj.name, obj.exRate)
        {
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public double ExRate
        {
            set
            {
                exRate = value;
            }
            get
            {
                return exRate;
            }
        }
    }
}
