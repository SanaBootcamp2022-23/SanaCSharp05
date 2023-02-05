using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Currency
    {   // поля оголошено(ззахищені) 3.5
        protected string name;
        protected double exRate;

        //сетери та гетери 3.7
        public string Name { get => name; set => name = value; }
        public double ExRate { get => exRate; set => exRate = value; }
        public Currency() 
        {
           //конструктор по замовчуванню 3.6
        }   
        public Currency(string name)
        {
            Name = name;
            //конструктор з параметрами 3.6
   
        }
        public Currency(string name, double exRate) 
        {
            Name = name;
            ExRate = exRate;
            //конструктор з параметрами 3.6
        }
        public Currency(Currency copyCurrency)
        {
            Name = copyCurrency.Name;
            ExRate = copyCurrency.ExRate;
            //конструктор копіювання 3.6
        }

    }
}
