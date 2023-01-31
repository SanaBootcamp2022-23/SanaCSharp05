using System;
using System.Data;

public class Currency
{
    protected string Name;
    protected double ExRate;
    
    public Currency()
    {
        Name = "hrn";
        ExRate = 1;
    }
    public Currency (double exRate)
    {
        Name = "idk";
        ExRate = exRate;
    }
    public Currency (string name, double exRate)
    {
        Name = name;
        ExRate = exRate;
    }
    public Currency (Currency obj) : this(obj.Name, obj.ExRate) { }
    public string GetName() => Name;
    public double GetExRate() => ExRate;
    public void SetName(string name ) => Name = name;
    public void SetExRate(double exRate) => ExRate = exRate;
    public float GetPriceInUAH(float price)
    {
        return (float)(price*ExRate); 
    }
    public float GetTotalPriceInUAH(float price, int quantity)
    {
        return (float)(price * quantity * ExRate);
    }
    public float GetTotalWeight(int quantity, float weight)
    {
        return (float)(quantity * weight);
    }
}
