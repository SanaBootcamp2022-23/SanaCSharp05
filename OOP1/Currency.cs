namespace OOP1
{
    enum Currencies
    {
        UAH, USD, EUR,
        PLN, GBP, CAD,
        Uknown
    }

    internal class Currency
    {
        private readonly string _name = "Uknown";
        private readonly Currencies _code = Currencies.Uknown;
        private double _exRate = 1;

        public string Name
        {
            get { return _name; }
        }

        public Currencies Code
        {
            get { return _code; }
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

        public Currency(string name, Currencies code, double exRate)
        {
            _name = name;
            _code = code;
            ExRate = exRate;
        }

        public Currency(Currencies code, double exRate)
        {
            _code = code;
            ExRate = exRate;
        }

        public Currency(double exRate)
        {
            ExRate = exRate;
        }

        public Currency(Currency currency)
        {
            _name = currency.Name;
            _code = currency.Code;
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
