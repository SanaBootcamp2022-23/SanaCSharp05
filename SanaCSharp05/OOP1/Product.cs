namespace OOP1
{
    class Product
    {
        private string name;
        private string producer;
        private Currency cost;
        private int quantity;
        private double weight;
        private double price;

        public string Name { get => name; set => name = value; }        
        public string Producer { get => producer; set => producer = value; }
        public Currency Cost { get => cost; set => cost = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Price { get => price; set => price = value; }

        public Product()
        {
            Name = "Unknown";
            Producer = "Unknown";
            Cost = new Currency();
            Quantity = 0;
            Weight = 0;
            Price = 0;
        }

        public Product(string name, string producer)
        {
            Name = name;
            Producer = producer;
        }

        public Product(string name, string producer, Currency cost, int quantity, double weight, double price) : this (name, producer)
        {
            Cost = cost;
            Quantity = quantity;
            Weight = weight;
            Price = price;
        }

        public Product(Product obj)
        {
            Name = obj.Name;
            Producer = obj.Producer;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Weight = obj.Weight;
            Price = obj.Price;
        }

        public double GetTotalWeight() => Quantity * Weight;

        public double GetPriceInUAH() => Cost.ExRate * Price;

        public double GetTotalPriceInUAH() => GetPriceInUAH() * Quantity;
    }
}
