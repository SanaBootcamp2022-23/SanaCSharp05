using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        protected string Name;
        protected double ExRate;

        protected Currency() { }

        public Currency(string name, double exRate)
        {
            this.Name = name;
            this.ExRate = exRate;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
        public string NAme
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public double EXRate
        {
            get
            {
                return ExRate;
            }
            set
            {
                ExRate = value;
            }
        }
    }
}