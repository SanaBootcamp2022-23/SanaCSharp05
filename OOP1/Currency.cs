namespace OOP1
{
    internal class Currency
    {
        private readonly string _name = "Uknown";
        private double _exRate = 1;

        public string Name
        {
            get { return _name; }
        }

        public double ExRate
        {
            get { return _exRate; }
            set
            {
                if (value > 0)
                    _exRate = value;
            }
        }

        public Currency() { }

        public Currency(string name, double exRate)
        {
            _name = name;
            ExRate = exRate;
        }

        public Currency(double exRate)
        {
            ExRate = exRate;
        }

        public Currency(Currency currency)
        {
            _name = currency.Name;
            ExRate = currency.ExRate;
        }

        /// <summary>
        /// Create a new copy of this Currency object.
        /// </summary>
        /// <returns>Currency</returns>
        public Currency Copy()
        {
            return new(this);
        }
    }
}
