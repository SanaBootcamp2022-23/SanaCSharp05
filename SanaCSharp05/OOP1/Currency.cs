using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        public string Name { get; set; } = "Name";

        private double exRate;
        public double ExRate 
        {
            get { return exRate; }
            set {
                if (value > 0)
                    exRate = value;
                else 
                    throw new ArgumentException("курс валюти має бути більше нуля");

            } 
        }

        public Currency(Currency currency)
        {
            ExRate = currency.ExRate;
            Name = currency.Name;
        }
        public Currency()
        {           

        }
        public Currency(double rate, string name)
        {
            ExRate =rate;
            Name = name;
        }
        public Currency( string name)
        {           
            Name = name;
        }


    }
}
