namespace OOP1
{
    public class Currency
    {
        private string _unitName;
        private double _exchangeRate;

        public string UnitName
        {
            get { return _unitName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _unitName = value;
                else throw new Exception("Invalid Unit Name");
            }
        }

        public double ExchangeRate
        {
            get { return _exchangeRate; }
            set
            {
                if (value > 0)
                    _exchangeRate = value;
                else throw new Exception("Invalid Exchange Rate");
            }
        }

        public Currency()
        {
            UnitName = "USD";
            ExchangeRate = 36.75;
        }

        public Currency(string unitName, double exchangeRate)
        {
            UnitName = unitName;
            ExchangeRate = exchangeRate;
        }

        public Currency(Currency obj)
        {
            this.UnitName = obj.UnitName;
            this.ExchangeRate = obj.ExchangeRate;
        }
    }
}
