namespace OOP1
{
    class Currency
    {
        protected string Name;
        protected decimal ExRate;

        public Currency()
        {
            Name = "UAH";
            ExRate = 0;
        }

        public Currency(string name, decimal exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
            ExRate = 0;
        }

        public Currency(decimal exRate)
        {
            Name = "UAH";
            ExRate = exRate;
        }

        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }

        public void setName(string name)
        {
            if (name != null)
                Name = name;
        }

        public void setExRate(decimal exRate)
        {
            if (exRate > 0)
                ExRate = exRate;
        }

        public string getName()
        {
            return Name;
        }

        public decimal getExRate()
        {
            return ExRate;
        }

    }
}