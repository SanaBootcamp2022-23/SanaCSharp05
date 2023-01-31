using System;

public class Product
{
	protected string Name;
	protected float Price;
	protected Currency Cost;
	protected int Quantity;
	protected string Producer;
	protected float Weight;

	public Product()
	{
		Name = "sok";
		Price = 20;
		Cost = new Currency();
		Quantity = 1;
		Producer = "sok";
		Weight = 20;
	}
	public Product(string name, float price, Currency cost, int quantity, string producer, float weight)
	{
		Name = name;
		Price = price;
		Cost = new Currency(cost);
		Quantity = quantity;
		Producer = producer;
		Weight = weight;
	}
    public Product(string name, float price, Currency cost, int quantity, string producer)
    {
        Name = name;
        Price = price;
        Cost = new Currency(cost);
        Quantity = quantity;
        Producer = producer;
        Weight = 20;
    }
	public string GetName()=> Name;
	public float GetPrice() =>	Price;	
	public Currency GetCost() => Cost;	
	public int GetQuantity() => Quantity;
	public string GetProducer() => Producer;
	public float GetWeight() => Weight;

	public void SetName(string name) { Name = name; }
	public void SetPrice(float price) { Price = price; }
	public void SetCost(Currency cost) { Cost = cost; }	
	public void SetQuantity(int quantity) { Quantity = quantity; }
	public void SetProducer(string producer) { Producer = producer; }
	public void SetWeight(float weight) { Weight = weight; }

}
