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
        public Currency()//конструктор по замовчуванню
        {
            Name = "UAH";
            ExRate = 30.70;
        }

        public Currency(string name, double exRate)//конструктор з параметром
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)//конструктор з параметром
        {
            Name = name;
        }
        public Currency(double exRate)//конструктор з параметром
        {
            ExRate = exRate;
        }
        public Currency(Currency obj)//конструктор копіювання
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }

        //властивості Get- та Set-
        public string GetName()
        {
            return Name;
        }

        public double GetExRate()
        {
            return ExRate;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetExRate(double exRate)
        {
            ExRate = exRate;
        }
    }
}
