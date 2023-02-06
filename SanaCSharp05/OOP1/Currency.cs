using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        private string _name;
        private double _exRate;

        public Currency()
        {
            Name = "UAH";
            ExRate= 1;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
           
        }
        public Currency(Currency CopyCurency)
        {
            Name= CopyCurency.Name;
            ExRate= CopyCurency.ExRate;
        }

        public void PrintCost()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("ExRate: " + ExRate);
        }
        public string Name
        {
            get 
            {
                return _name; 
            }
            set 
            {
                _name = value; 
            }
        }
        public double ExRate
        {
            get
            {
                return _exRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _exRate = value;
            }
        }


    }
}
