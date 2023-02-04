namespace OOP1.classes.Products
{
    public class Currency
    {
        protected string Name;
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        protected double ExRate;
        public double exRate
        {
            get { return this.ExRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ExRate", "ExRate must be over zero");
                }
                this.ExRate = value;
            }
        }

        //default constructor
        public Currency()
        {
            this.Name = "hryvnia";
            this.ExRate = 1;
        }

        //parameterized constructor
        public Currency(string Name, double ExRate)
        {
            this.Name = Name;
            if (ExRate <= 0)
            {
                throw new ArgumentOutOfRangeException("ExRate", "ExRate must be over zero");
            }
            this.ExRate = ExRate;
        }

        //parameterized constructor 2
        public Currency(double ExRate)
        {
            this.Name = "";
            if (ExRate <= 0)
            {
                throw new ArgumentOutOfRangeException("ExRate", "ExRate must be over zero");
            }
            this.ExRate = ExRate;
        }

        //copy constructor
        public Currency(Currency currency)
        {
            this.Name = currency.Name;
            this.ExRate = currency.ExRate;
        }
    }
}