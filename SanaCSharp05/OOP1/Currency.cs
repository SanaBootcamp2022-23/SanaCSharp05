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
        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
            }
            get { return name; }
        }

        public double exRate;
        public double ExRate
        {
            set
            {
                if (value > 0)
                    exRate = value;
            }
            get { return exRate; }
        }

        public Currency()
        {
            Name = "USD";
            ExRate = 36.84;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(double exRate)
        {
            Name = "USD";
            ExRate = exRate;
        }

        public Currency(Currency copied) : this(copied.Name, copied.ExRate)
        {

        }

    }
}
