using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        protected string name;
        protected decimal exRate;
        public Currency()
        {

        }

        public Currency(string name, decimal exRate)
        {
            this.name = name;
            this.exRate = exRate;
        }

        public Currency(string name)
        {
            this.name = name;
        }

        public Currency(decimal exRate)
        {
            this.exRate = exRate;
        }
        public Currency(Currency obj)
        {
            name = obj.name;
            exRate = obj.exRate;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal ExRate
        {
            get { return exRate; }
            set { exRate = value; }
        }
    }
}
