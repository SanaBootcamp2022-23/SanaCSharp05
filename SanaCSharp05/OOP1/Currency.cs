using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        protected string Name;
        protected float ExRate;



        public Currency()
        {
            Name = "Гривня";
            ExRate = 1;
        }

        public Currency(string name, float exRate)
        {
            Name = name;
            ExRate = exRate;
        }


        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public float exRate
        {
            get { return ExRate; }
            set { ExRate = value; }
        }
    }
}