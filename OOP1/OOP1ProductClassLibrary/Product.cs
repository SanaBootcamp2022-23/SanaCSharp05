namespace OOP1ProductClassLibrary;

public class Product
{
    protected Currency cost; //грошова одиниця

    //ЗАХИЩЕНІ ПОЛЯ 
    protected string name; //назва товару
    protected double price; //вартість одиниці товару
    protected string producer; //виробник
    protected int quantity; //кількість наявних товарів на складі
    protected double weight; //вага

    //КОНСТРУКТОР ЗА ЗАМОВЧУВАННЯМ
    public Product()
    {
        name = "Mi Band 6";
        price = 29.6;
        cost = new Currency();
        quantity = 100;
        producer = "Xiaomi";
        weight = 45.7;
    }

    //КНОСТРУКТОРИ З ПАРАМЕТРАМИ
    public Product(string name)
    {
        this.name = name;
        price = 29.6;
        cost = new Currency();
        quantity = 100;
        producer = "Xiaomi";
        weight = 45.7;
    }

    public Product(double price)
    {
        name = "Mi Band 6";
        this.price = price;
        cost = new Currency();
        quantity = 100;
        producer = "Xiaomi";
        weight = 45.7;
    }

    public Product(Currency currency)
    {
        name = "Mi Band 6";
        price = 29.6;
        cost = currency;
        quantity = 100;
        producer = "Xiaomi";
        weight = 45.7;
    }

    public Product(int quantity)
    {
        name = "Mi Band 6";
        price = 29.6;
        cost = new Currency();
        this.quantity = quantity;
        producer = "Xiaomi";
        weight = 45.7;
    }

    public Product(string name, Currency currency)
    {
        this.name = name;
        price = 29.6;
        cost = currency;
        quantity = 100;
        producer = "Xiaomi";
        weight = 45.7;
    }

    public Product(string name, string producer)
    {
        this.name = name;
        price = 29.6;
        cost = new Currency();
        quantity = 100;
        this.producer = producer;
        weight = 45.7;
    }

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
        cost = new Currency();
        quantity = 100;
        producer = "Xiaomi";
        weight = 45.7;
    }

    public Product(string name, int quantity)
    {
        this.name = name;
        price = 29.6;
        cost = new Currency();
        this.quantity = quantity;
        producer = "Xiaomi";
        weight = 45.7;
    }

    public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
    {
        this.name = name;
        this.price = price;
        this.cost = cost;
        this.quantity = quantity;
        this.producer = producer;
        this.weight = weight;
    }

    public Product(string name, double price, int quantity, string producer, double weight)
    {
        this.name = name;
        this.price = price;
        cost = new Currency();
        this.quantity = quantity;
        this.producer = producer;
        this.weight = weight;
    }

    public Product(string name, double price, Currency cost, int quantity, double weight)
    {
        this.name = name;
        this.price = price;
        this.cost = cost;
        this.quantity = quantity;
        producer = "Xiaomi";
        this.weight = weight;
    }

    public Product(string name, double price, Currency cost, int quantity, string producer)
    {
        this.name = name;
        this.price = price;
        this.cost = cost;
        this.quantity = quantity;
        this.producer = producer;
        weight = 45.7;
    }

    public Product(string name, double price, Currency cost, string producer)
    {
        this.name = name;
        this.price = price;
        this.cost = cost;
        quantity = 100;
        this.producer = producer;
        weight = 45.7;
    }

    public Product(string name, double price, Currency cost)
    {
        this.name = name;
        this.price = price;
        this.cost = cost;
        quantity = 100;
        producer = "Xiaomi";
        weight = 45.7;
    }

    //КОНСТРУКТОР КОПІЮВАННЯ
    public Product(Product product)
    {
        name = product.Name;
        price = product.Price;
        cost = product.Cost;
        quantity = product.Quantity;
        producer = product.Producer;
        weight = product.Weight;
    }

    //ВЛАСТИВОСТІ ДЛЯ ПОЛІВ
    public string Name
    {
        get => name;
        set => name = value;
    }

    public double Price
    {
        get => price;
        set => price = value < 0 ? 0 : value;
    }

    public Currency Cost
    {
        get => cost;
        set => cost = value;
    }

    public int Quantity
    {
        get => quantity;
        set => quantity = value < 0 ? 0 : value;
    }

    public string Producer
    {
        get => producer;
        set => producer = value;
    }

    public double Weight
    {
        get => weight;
        set => weight = value < 0 ? 0 : value;
    }

    public double GetPriceInUAH()
    {
        return Math.Round(Price * Cost.ExRate, 2);
    }

    public double GetTotalPriceInUAH()
    {
        return Math.Round(GetPriceInUAH() * Quantity, 2);
    }

    public double GetTotalWeight()
    {
        return Math.Round(Quantity * Weight, 2);
    }

    public string ToString()
    {
        return $"Name: {Name}\n" +
               $"Price: {Price}\n" +
               $"Cost: {Cost.ToString()}\n" +
               $"Quantity: {Quantity}\n" +
               $"Producer: {Producer}\n" +
               $"Weight: {Weight}\n" +
               $"Price in UAH: {GetPriceInUAH()}\n" +
               $"Total price in UAH: {GetTotalPriceInUAH()}\n" +
               $"Total weight: {GetTotalWeight()}\n";
    }
}