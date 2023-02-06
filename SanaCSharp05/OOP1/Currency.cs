using System;
namespace OOP1
{
    public class Currency
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { if (!String.IsNullOrEmpty(name)) name = value; }
        }
        protected double exRate;
        public double ExRate{
            get { return exRate; }
            set { if (value > 0) exRate = value; }
        }
  

        public Currency()
        {
            Name = "Euro";
            ExRate = 40.32;
        }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency(string name, double exRate) : this(name)
        {
            ExRate = exRate;
        }
        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
    }
}
