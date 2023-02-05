namespace OOP1
{


    class Product
    {
        protected string Name;
        protected decimal Price;
        protected Currency Cost;
        protected uint Quantity;
        protected string Producer;
        protected double Weight;

        public Product()
        {
            Name = "Apple";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "ATB";
            Weight = 0;
        }

        public Product(string name, decimal price, Currency cost, uint quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, decimal price, Currency cost, uint quantity, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = "NOVUS";
            Weight = weight;
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Silpo";
            Weight = 0;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = new Currency(product.Cost);
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

        public void setName(string name)
        {
            if (name != null)
                Name = name;
        }

        public void setPrice(decimal price)
        {
            if (price > 0)
                Price = price;
        }

        public void setCost(Currency cost)
        {
            if (cost != null)
                Cost = new Currency(cost);

        }

        public void setQuantity(uint quantity)
        {
            if (quantity > 0)
                Quantity = quantity;
        }

        public void setProducer(string producer)
        {
            if (producer != null)
                Producer = producer;
        }

        public void setWeight(double weight)
        {
            if (weight > 0)
                Weight = weight;
        }

        public string getName()
        {
            return Name;
        }

        public decimal getPrice()
        {
            return Price;
        }

        public Currency getCost()
        {
            return Cost;
        }

        public uint getQuantity()
        {
            return Quantity;
        }

        public string getProducer()
        {
            return Producer;
        }

        public double getWeight()
        {
            return Weight;
        }

        public decimal GetPriceInUAH()
        {
            return Price * Cost.getExRate();
        }

        public decimal GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}