using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Currency
    {
        private string _nameVal;
        private double _exRate; 
        public string NameVal
        {
            get {return _nameVal;}
            set {_nameVal = value; }
        }
        public double ExRate
        {
            get { return _exRate;}
            set { if (value > 0)
                {
                    _exRate = value;
                } }
        }
        public Currency() { }
        public Currency(string _nameVal, double _exRate)
        {
            NameVal = _nameVal;
            ExRate= _exRate;
        }
        public Currency(double exRate)
        {
            ExRate = exRate;
        }
    }
}
