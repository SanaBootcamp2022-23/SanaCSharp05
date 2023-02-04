using System.Xml.Linq;

namespace ClassLibrary05
{
    public class Currency
    {
        protected string Name { get; set; }
        protected double ExRate { get; set; }

        public Currency(Currency PrevCurrency)
        {
            Name = PrevCurrency.Name;
            ExRate = PrevCurrency.ExRate;
        }

        public Currency()
        {
            Name = "Dollar";
            ExRate = 37.28;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public void SetName(string name) => Name = name;
        public void SetExRate(double exRate) 
        {
            if (exRate < 0)
                exRate = 0;

            ExRate = exRate;
        }
        public string GetName() => Name;
        public double GetExRate() => ExRate;

    }
}
