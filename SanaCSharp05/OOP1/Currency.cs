using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{ 

    public class Currency
{
    public string name = "NoName";
    public decimal ex_rate;
    public string Name
    {
        get 
            {
                return name;
            }
        set { 
                if (name != "") 
                    name = value; 
            }
    }
    public decimal ExRate
    {
        get 
            { 
                return ex_rate; 
            }
        set { 
                if (value > 0)
                    ex_rate = value; 
            }
    }
    public Currency() 
        { }
    public Currency(string name, decimal ex_rate)
    {
        this.name = name;
        this.ex_rate = ex_rate;
    }
    public Currency(decimal ex_rate)
    {
        this.ex_rate = ex_rate;
    }
        public Currency(Currency currency)
        {
            name = currency.name;
            ex_rate = currency.ex_rate;
        }

    }
}