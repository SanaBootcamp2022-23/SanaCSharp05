namespace OOP1
{
    public class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public string name
        {
            get { return Name; }
            set { if (value != null) { Name = value; } }
        }

        public double price
        {
            get { return Price; }
            set { if (value > 0) { Price = value; } }
        }

        public Currency cost
        {
            get { return Cost; }
            set { if (value != null) { Cost = value; } }
        }

        public int quantity
        {
            get { return Quantity; }
            set { if (value >= 0) { Quantity = value; } }
        }

        public string producer 
        {
            get { return Producer; }
            set { if (value != null) { Producer = value; } }
        }

        public double weight
        {
            get { return Weight; }
            set { if (value >= 0) { Weight = value; } }
        }
        
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, int quantity, double weight) : this(name,price,new Currency("US Dollar",40),quantity,"ROSHEN",weight) { }

        public Product():this("Undefined",0,new Currency(),0,"Undefined",0) { }

        public Product(Product product):this(product.Name,product.Price, product.Cost, product.Quantity, product.Producer, product.Weight) { }

        public double GetPriceInUAH()
        {
            return Price*Cost.exRate;
        }
        
        public double GetTotalPriceInUAH()
        {
            return Price*Cost.exRate*Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight*Quantity;
        }
    }
}
