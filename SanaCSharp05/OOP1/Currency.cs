namespace OOP1
{
    public class Currency
    {
        protected string Name;
        protected double ExRate;

        public string name
        {
            get { return Name; }
            set {if(value != null) { Name = value; } }
        }

        public double exRate
        {
            get { return ExRate; }
            set { if (value > 0) { ExRate = value; } }
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name) : this(name,25) { }

        public Currency() : this("Undefined",0.0) { }

        public Currency(Currency cur) : this(cur.Name,cur.ExRate) { }


    }
}
