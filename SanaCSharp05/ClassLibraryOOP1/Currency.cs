using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOOP1
{
    public class Currency
    {
        protected string Name;
        protected decimal ExRate;

        public Currency(string name, decimal exRate)
        {
            this.Name = name;
            this.ExRate = exRate;
        }
        public Currency(decimal exRate)
        { 
            this.ExRate = exRate;
        }

        public Currency(Currency previousCurrency)
        { 
            this.Name = previousCurrency.Name;
            this.ExRate = previousCurrency.ExRate;
        }

        public string name
        {
            set { Name = value; }
            get { return Name; }
        }

        public decimal exRate
        {
            set { ExRate = value; }
            get { return ExRate; }  
        }
    }
}
