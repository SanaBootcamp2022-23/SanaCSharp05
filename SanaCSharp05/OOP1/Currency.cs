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
            get { return name; }
            set { name = value; }
        }
        protected double exrate;
        public double ExRate
        {
            get { return exrate; }
            set
            {
                exrate = value;
            }
        }
        public Currency(string name, double exrate, double exRate)
        {
            this.name = name;

            this.exrate = exrate;
            ExRate = exRate;
        }

        public double GetPriceInUAH(double cost, double exrate)
        {
            return exrate * cost;
        }
        public double GetTotalPrice(double quantity, double cost)
        {
            return (exrate * cost) * quantity;
        }
        public double GetTotalWeight(double weight, double quantity)
        {
            return weight * quantity;
        }
        public Currency(Currency obj)
        {
            name = obj.Name;
            exrate = obj.ExRate;
        }
    }
}