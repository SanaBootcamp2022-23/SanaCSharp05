namespace OOP1;

public class Currency
{
    protected string Name;
    protected double ExRate;
    public Currency()
    {
        Name = "UAH";
        ExRate = 1;
    }

    public Currency(string name, double exRate)
    {
        Name = name;
        ExRate = exRate;
    }

    public Currency(Currency other)
    {
        Name = other.Name;
        ExRate = other.ExRate;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public double GetExRate()
    {
        return ExRate;
    }

    public void SetExRate(double exRate)
    {
        ExRate = exRate;
    }
    public override string ToString()
    {
        return $"{Name} ({ExRate})";
    }

    public double ConvertTo(double value, Currency targetCurrency)
    {
        return value / ExRate * targetCurrency.ExRate;
    }

    public static List<Currency> GetAllCurrencies()
    {
        return new List<Currency>
        {
            new Currency("UAH", 1),
            new Currency("USD", 39),
            new Currency("EUR", 41)
        };
    }
}