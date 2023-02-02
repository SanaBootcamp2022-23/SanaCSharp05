using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        private readonly string _name = "Uknown";
        private double _exRate = 1;

        //властивості
        public string Name
        {
            get { return _name; }
        }
        public double ExRate
        {
            set
            {
                if (value > 0)
                    _exRate = value;
            }
            get { return _exRate; }
        }

        //по замовчуванню
        public Currency() { }
        //конструктори з параметрами
        public Currency(string name)
        {
            _name = name;
        }
        public Currency(double exRate)
        {
            ExRate = exRate;
        }
        public Currency(string name, double exRate)
        {
            _name = name;
            ExRate = exRate;
        }
        //конструктор копіювання
        public Currency(Currency currency)
        {
            _name = currency.Name;
            ExRate = currency.ExRate;
        }
        public Currency Copy()
        {
            return new(this);
        }
    }
}