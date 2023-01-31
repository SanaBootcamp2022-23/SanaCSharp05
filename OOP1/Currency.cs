namespace OOP1
{
    public class Currency
    {
        protected CurrencyName _name;
        protected double _exRate;

        public CurrencyName Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double ExRate
        {
            get { return _exRate; }
            set
            {
                if(value>0)
                    _exRate = value;
            }
        }
        public Currency()
        {
            _name = CurrencyName.USD;
            _exRate = 36.93;
        }
        public Currency(CurrencyName name, double exrate)
        {
            Name = name;
            ExRate = exrate;
        }
        public Currency(Currency obj)
        {
            _name = obj._name;
            _exRate = obj._exRate;
        }
    }
}