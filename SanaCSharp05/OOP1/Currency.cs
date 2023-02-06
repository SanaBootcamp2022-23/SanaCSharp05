using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Currency
    {
        protected string Name = "USD";
        protected double ExRate = 39.5;

        //Конструктор по замовчуванню
        public Currency() { }
        
        //Set та Get 
        public string name
        {
            get { return Name; }
            set { if (value != null) { Name = value; } }
        }
        public double exRate
        {
            get { return ExRate; }
            set { if (value > 0) { ExRate = value; } }
        }
        
        //Конструктори з параметрами
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }      
        public Currency(double exRate)
        {
            ExRate = exRate;
        }
   
        //Конструктор копіювання
        public Currency(Currency copyCurr) : this(copyCurr.Name, copyCurr.ExRate) { }
    }
}
