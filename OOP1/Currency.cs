using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        public static Currency Default = new Currency("UAH", 1);
        protected string Name = "";
        protected double ExRate;

        public string Name_
        {
            get { return Name; }
            set { if (!string.IsNullOrEmpty(value)) Name = value; }
        }
        public double ExRate_
        {
            get { return ExRate; }
            set { ExRate = value; }
        }
        public Currency(){}
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(string name)
        {
            Name = name;
            ExRate= 1;
        }
        public Currency(Currency PreviousCurrency)
        {
            Name = PreviousCurrency.Name;
            ExRate = PreviousCurrency.ExRate;
        }
        public Currency Copy()
        {
            return new(this);
        }
    }
}
