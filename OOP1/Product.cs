namespace OOP1
{
    internal class Product
    {
        private string _name = "Unknown";
        private double _price = 0;
        private Currency _cost = new();
        private int _quantity = 0;
        private string _producer = "Unknown";
        private double _weight = 0;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }

        public Currency Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= 0)
                    _quantity = value;
            }
        }

        public string Producer
        {
            get { return _producer; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _producer = value;
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value >= 0)
                    _weight = value;
            }
        }

        public Product() { }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(double price, Currency cost, int quantity, double weight)
        {
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Weight = weight;
        }

        public Product(double price, Currency cost)
        {
            Price = price;
            Cost = cost;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost.Copy();
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

        /// <summary>
        /// Create a new copy of this Product object.
        /// </summary>
        /// <returns>Product</returns>
        public Product Copy()
        {
            return new(this);
        }

        /// <summary>
        /// Calculate price of the product in Ukrainian Hryvnia.
        /// </summary>
        /// <returns>Price in UAH</returns>
        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }

        /// <summary>
        /// Calculate the total price of all products in Ukrainian Hryvnia.
        /// </summary>
        /// <returns>Total price in UAH</returns>
        public double GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }

        /// <summary>
        /// Calculate the total weight of all products.
        /// </summary>
        /// <returns>Total weight</returns>
        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
}
