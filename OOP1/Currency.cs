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
        
        public Currency()
        {
            this.Name = "гривня";
            this.ExRate = 1;
        }

        public Currency(string name, double exRate):this(exRate)
        {
            this.Name = name;
        }

        public Currency(double exRate)
        { 
            this.ExRate = exRate;
            this.Name = "own_currency";
        }

        public Currency(Currency obj)
        {
            this.Name = obj.Name;
            this.ExRate = obj.ExRate;
        }

        public string GetNameCurrency()
        {
            return this.Name;
        }

        public double GetExRateCurrency()
        {
            return this.ExRate;
        }

        public void SetNameCurrency(string name)
        {
            if (name.Length >= 2)
            {
                this.Name = name;
            }
        }

        public void SetExRateCurrency(double exRate)
        {
            if (exRate > 0)
            {
                this.ExRate = exRate;
            }
        }
    }
}
