using System;

namespace OOP1;
public class Product {
    private string _name = "Undefined";
    private decimal _price;
    private Currency _cost = new Currency();
    private int _quantity;
    private string _producer = "Undefined";
    private double _weight;

    public string Name { get => _name; set => _name = value ?? "Undefined"; }
    public decimal Price { get => _price; set => _price = value; }
    public Currency Cost { get => _cost; set => _cost = value ?? new Currency(); }
    public int Quantity { get => _quantity; set => _quantity = value; }
    public string Producer { get => _producer; set => _producer = value ?? "Undefined"; }
    public double Weight { get => _weight; set => _weight = value; }

    public Product() {}

    public Product(string name, decimal price, Currency cost, int quantity, 
            string producer, double weight){
        this.Name = name;
        this.Price = price;
        this.Cost = cost;
        this.Quantity = quantity;
        this.Producer = producer;
        this.Weight = weight;
    }

    public Product(string name, decimal price, Currency cost, int quantity){
        this.Name = name;
        this.Price = price;
        this.Cost = cost;
        this.Quantity = quantity;
    }

    public Product(Product product){
        this.Name = product.Name;
        this.Price = product.Price;
        this.Cost = new Currency(product.Cost);
        this.Quantity = product.Quantity;
        this.Producer = product.Producer;
        this.Weight = product.Weight;
    }

    public override string ToString() {
        return $"Name: {this.Name}, price: {this.Price}, cost: {this.Cost}" + 
            $", quantity: {this.Quantity}, producer: {this.Producer}, weight: {this.Weight}";
    }

    public decimal GetPriceInUAH() {
        return this.Price * this.Cost.ExRate;
    }

    public decimal GetTotalPriceInUAH() {
        return this.Quantity * GetPriceInUAH();
    }

    public double GetTotalWeight() {
        return this.Quantity * this.Weight;
    }
}

