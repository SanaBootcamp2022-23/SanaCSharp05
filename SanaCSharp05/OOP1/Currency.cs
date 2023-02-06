namespace OOP1
{
    class Currency
    {
        private string name;
        private double exRate;

        public string Name { get => name; set => name = value; }
        public double ExRate { get => exRate; set => exRate = value; }

        public Currency()
        {
            Name = "Unknown";
            ExRate = 1;
        }

        public Currency(double exRate) : this()
        {
            ExRate = exRate;
        }

        public Currency(string name, double exRate) : this(exRate)
        {
            Name = name;
        }

        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
    }
}
