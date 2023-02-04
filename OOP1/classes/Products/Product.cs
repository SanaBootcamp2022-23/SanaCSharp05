namespace OOP1.classes.Products
{
    public class Product
    {
        protected string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        protected double Price;
        public double price
        {
            get { return Price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price must be above zero");
                }
                Price = value;
            }
        }

        protected Currency Cost;
        public Currency cost
        {
            get { return Cost; }
            set { Cost = value; }
        }

        protected int Quantity;
        public int quantity
        {
            get { return Quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity", "Quantity must be above zero");
                }
                Quantity = value;
            }
        }

        protected string Producer;
        public string producer
        {
            get { return Producer; }
            set { Producer = value; }
        }

        protected double Weight;
        public double weight
        {
            get { return Weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weight", "Weight must be above zero");
                }
                Weight = value;
            }
        }

        //default constructor
        public Product()
        {
            this.Name = "Javelin";
            this.Price = 216.71;
            this.Cost = new Currency("dollar", 37.28);
            this.Quantity = 3;
            this.Producer = "US Army";
            this.Weight = 6.4;
        }

        //parameterized constructor
        public Product(string Name, double Price, Currency Cost, int Quantity, string Producer, double Weight)
        {
            this.Name = Name;
            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("Price", "Price must be above zero");
            }
            this.Price = Price;
            this.Cost = Cost;
            if (Quantity <= 0)
            {
                throw new ArgumentOutOfRangeException("Quantity", "Quantity must be above zero");
            }
            this.Quantity = Quantity;
            this.Producer = Producer;
            if (Weight <= 0)
            {
                throw new ArgumentOutOfRangeException("Weight", "Weight must be above zero");
            }
            this.Weight = Weight;
        }

        //parameterized constructor 2
        public Product(string Name, double Price, string Producer)
        {
            this.Name = Name;
            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("Price", "Price must be above zero");
            }
            this.Price = Price;
            this.Cost = new Currency();
            this.Quantity = 1;
            this.Producer = Producer;
            if (Weight <= 0)
            {
                throw new ArgumentOutOfRangeException("Weight", "Weight must be above zero");
            }
            this.Weight = 1;
        }

        //copy constructor
        public Product(Product product)
        {
            this.Name = product.Name;
            this.Price = product.Price;
            this.Cost = product.Cost;
            this.Quantity = product.Quantity;
            this.Producer = product.Producer;
            this.Weight = product.Weight;
        }

        public double GetPriceInUAH()
        {
            return this.Price * this.Cost.exRate;
        }

        public double GetTotalPriceInUAH()
        {
            return this.Price * this.Cost.exRate * this.Quantity;
        }

        public double GetTotalWeight()
        {
            return this.Quantity * this.Weight;
        }
    }
}