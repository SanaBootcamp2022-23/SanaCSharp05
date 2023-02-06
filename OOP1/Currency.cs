
namespace OOP1
{
    public class Currency
    {
        protected string name;
        protected double exRate;

        public Currency()
        {
            name = "";
            exRate = 0;
        }

        public Currency(string name, double exRate)
        {
            this.name = name;
            this.exRate = exRate;
        }

        public Currency(string name) : this(name, 0)
        { }

        public Currency(Currency othercurrency)
        {
            this.name = othercurrency.name;
            this.exRate = othercurrency.exRate;
        }

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
            get { return name; }
        }
        public double ExRate
        {
            set
            {
                if (value >= 0)
                {
                    exRate = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                }
            }
            get { return exRate; }
        }
    }
}
