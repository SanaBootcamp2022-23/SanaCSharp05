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
            Name = "UAH";
            ExRate = 40.14;
        }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency(double exRate)
        {
           ExRate=exRate;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetExRate()
        {
            return ExRate;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetExRate(double exRate)
        {
            ExRate = exRate;
        }
    }
}
