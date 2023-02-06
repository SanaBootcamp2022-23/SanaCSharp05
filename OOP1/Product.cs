
namespace OOP1
{
    public class Product
    {
        protected string name;
        protected int price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;

        public Product() 
        {
            name = "";
            price = 0;
            cost = new Currency();
            quantity = 0;
            producer = "";
            weight = 0;
        }

        public Product(string name, int price, Currency cost, int quantity, string producer, double weight)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }

        public Product(string name, int price, Currency cost, int quantity) : this(name, price, cost, quantity, "", 0)
        { }

        public Product(Product otherproduct)
        {
            this.name = otherproduct.name;
            this.price = otherproduct.price;
            this.cost = otherproduct.cost;
            this.quantity = otherproduct.quantity;
            this.producer = otherproduct.producer;
            this.weight = otherproduct.weight;
        }

        public string Name
        {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
            get { return name; }
        }
        public int Price
        {
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
            get { return price; }
        }
        public Currency Cost
        {
            set
            {
                cost = value;
            }
            get { return cost; }
        }
        public int Quantity
        {
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
            get { return quantity; }
        }
        public string Producer
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    producer = value;
            }
            get { return producer; }
        }
        public double Weight
        {
            set
            {
                if (value >= 0)
                    weight = value;
            }
            get { return weight; }
        }
    }
}
