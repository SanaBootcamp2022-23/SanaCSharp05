using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{

    class Currency
    {
        public static Currency Default = new Currency("UAH", 1);

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > Constants.MAX_STRING_SIZE)
                    throw new ArgumentException("String too long!");
                name = value;
            }
        }
        protected string name;
        public double ExRate { get; set; }

        public Currency()
        {
            Name = "New Currency";
            ExRate = 1;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
            ExRate = 1;
        }

        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
    }
}
