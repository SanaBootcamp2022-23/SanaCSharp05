namespace OOP1ProductClassLibrary;

public class Currency
{
    protected double exRate;

    //ЗАХИЩЕНІ ПОЛЯ 
    protected string name;

    //КОНСТРУКТОР ЗА ЗАМОВЧУВАННЯМ
    public Currency()
    {
        name = "USD";
        exRate = 36.7;
    }

    //КОНСТРУКТОРИ З ПАРАМТЕРАМИ
    public Currency(string name, double exRate)
    {
        this.name = name;
        this.exRate = exRate;
    }

    public Currency(string name)
    {
        this.name = name;
        exRate = 36.7;
    }

    public Currency(double exRate)
    {
        name = "USD";
        this.exRate = exRate;
    }

    //КОНСТРУКТОР КОПІЮВАННЯ
    public Currency(Currency currency)
    {
        name = currency.name;
        exRate = currency.exRate;
    }

    //ВЛАСТИВОСТІ для ПОЛІВ
    public string Name
    {
        get => name;
        set => name = value;
    }

    public double ExRate
    {
        get => exRate;
        set => exRate = value < 0 ? 0 : value;
    }

    public string ToString()
    {
        return $"{Name} - {ExRate}";
    }
}