using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        private string _name = "Unknown currency";
        private double _exRate = 35;
        public Currency()
        {

        }
        public Currency(string name, double exRate)
        {

        }
        public Currency(Currency currency)
        {
            _name = currency._name;
            _exRate = currency._exRate;
        }

        public string Name 
        {
            get => _name;
            set => _name = value;
        }
        public double ExRate 
        {
            get => _exRate; 
            set 
            {
                if (value > 0) 
                {
                    _exRate = value;
                }
            }
        }
        
    }
}
