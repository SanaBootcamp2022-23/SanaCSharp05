using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    internal class Currency
    {
        protected string Name;
        protected double ExRate;
        public string NAME 
        { 
            get 
            { 
                return Name; 
            } 
            set
            { 
                Name = value; 
            } 
        }
        public double EXRate { get { return ExRate; } set { ExRate = value; } }
        public Currency() 
        {
            Name = "Unknown";
            ExRate = 0.0;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(string name)
        {
            Name = name;
            ExRate = 0.0;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
        public override string ToString()
        {
            return $"Name of currency : {Name}\n" +
                   $"Rate to UAH : {ExRate}";
        }
    }
}
