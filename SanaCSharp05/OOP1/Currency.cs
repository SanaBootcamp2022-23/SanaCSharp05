using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public  class Currency
    {
        private string Name= "USD";
        private double ExRate = 36.56;
        public Currency() { }
        public Currency(string name, double exRate)
        {
            if (name.Length > 0 && name.Length <= 3) { Name = name; }
            if (exRate > 0) { ExRate = exRate; }
        }
        public Currency(string name)
        {
            if (name.Length > 0 && name.Length <= 3) { Name = name; }
        }
        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }

        public string GetName() { return Name; }
        public double GetExRate() { return ExRate; }

        public void SetName(string name) 
        { 
            if(name.Length>0 && name.Length <= 3) {Name = name;}
        }
        public void SetExRate(double exRate)
        {
            if (exRate > 0) { ExRate = exRate; }
        }
    }
}
