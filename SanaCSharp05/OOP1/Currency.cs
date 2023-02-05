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

        public Currency ()
        {
            Name = "UAH";
            ExRate = 1.00;
        }
        public Currency (string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency (string name)
        {
            Name = name;
            ExRate = 1.00;
        }
        public Currency(Currency crs)
        {
            Name= crs.Name;
            ExRate = crs.ExRate;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName (string name)
        {
            if (!String.IsNullOrEmpty(name))
                Name = name;
            else
                Name = "Uknown";
        }
        public double GetExRate ()
        {
            return ExRate;
        }
        public void SetExRate (double exRate)
        {
            if (exRate >= 0)
                ExRate = exRate;
            else
                ExRate = 1.00; 
        }

    }
}
