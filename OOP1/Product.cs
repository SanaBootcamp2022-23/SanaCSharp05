namespace OOP1
{
    class Product
    {
        protected string _Name;
        protected double _Price;
        protected Currency _Cost;
        protected uint _Quantity;
        protected string _Producer;
        protected double _Weight;

        public Product()
        {
            _Name = "Golden Apple";
            _Price = 10;
            _Cost = new Currency();
            _Quantity = 1;
            _Producer = "Tree";
            _Weight = 1;
        }
        public Product(string name, double price, uint quantity, string producer)
        {
            _Name = name;
            _Price = price;
            _Cost = new Currency();
            _Quantity = quantity;
            _Producer = producer;
            _Weight = 1;
        }
        public Product(string name, double price, Currency cost, uint quantity, string producer, double weight)
        {
            _Name = name;
            _Price = price;
            _Cost = cost;
            _Quantity = quantity;
            _Producer = producer;
            _Weight = weight;
        }
        public Product(Product obj)
        {
            _Name = obj.Name;
            _Price = obj.Price;
            _Cost = obj.Cost;
            _Quantity = obj.Quantity;
            _Producer = obj.Producer;
            _Weight = obj.Weight;
        }

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public double Price
        {
            set { _Price = value; }
            get { return _Price; }
        }
        public Currency Cost
        {
            set { _Cost = value; }
            get { return _Cost; }
        }
        public uint Quantity
        {
            set { _Quantity = value; }
            get { return _Quantity; }
        }
        public string Producer
        {
            set { _Producer = value; }
            get { return _Producer; }
        }
        public double Weight
        {
            set { _Weight = value; }
            get { return _Weight; }
        }

    }
}
