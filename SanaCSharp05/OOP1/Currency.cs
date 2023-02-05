using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        protected string curName;
        protected double curValue;
        public string Name
        {
            set {  
                if (value != "")
                    curName = value;
            }
            get { 
                return curName; 
            }
        }
        public double ExRate
        {
            set {
                if (value > 0)
                    curValue = value;
            }
            get {
                return curValue;
            }
        }
        public Currency()
        {
            Name = "USD";
            ExRate = 36.93;
        }
        public Currency(string curName, double curValue)
        {
            Name = curName;
            ExRate = curValue;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
        public override string ToString() {
            return $"{Name}";
        }
    }
}
