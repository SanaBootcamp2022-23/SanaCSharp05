namespace OOP1
{
    class Currency
    {
        protected string _Name;
        protected double _ExRate;


        public Currency()
        {
            _Name = "Coin";
            _ExRate = 1;
        }
        public Currency(string name)
        {
            _Name = name;
            _ExRate = 1;
        }
        public Currency(string name, double exRate)
        {
            _Name = name;
            _ExRate = Math.Round(exRate, 2);
        }
        public Currency(Currency obj)
        {
            _Name = obj.Name;
            _ExRate = obj.ExRate;
        }
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public double ExRate
        {
            set { _ExRate = Math.Round(value, 2); }
            get { return _ExRate; }
        }

    }
}
