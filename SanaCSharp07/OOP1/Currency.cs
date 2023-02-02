using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        protected string name;
        protected double exRate;
        public string Name
            { get { return name; } 
            set {
                if (value != "")
                    name = value;
                else throw new Exception("Error");
            } 
        }
        public double ExRate
            { get { return exRate; }set { 
               if (value > 0)
                    exRate = value;
                else throw new Exception("Error");
            } 
        }
        public Currency()
        {
            Name = "USD";
            ExRate = 36.75;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(Currency obj)
        {
            this.Name = obj.Name;
            this.ExRate = obj.ExRate;
        }

    }
}
