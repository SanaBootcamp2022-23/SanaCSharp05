namespace OOP1
{
    public class Currency
    {
        public string Name { get; private set; } = "";
        public double ExRate { get; private set; }

        public Currency() { }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
    }
}