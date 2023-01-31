namespace OOP1;

public class Currency
{
    public string Name { get; set; }

    private decimal exRate;
    public decimal ExRate
    {
        get { return exRate; }
        set { SetExchangeRate(value); }
    }

    public Currency(string name, decimal exRate)
    {
        Name = name;
        ExRate = exRate;
    }

    public Currency() : this("UAH", 1.00m) { }
    public Currency(string name) : this(name, 1.00m) { }
    public Currency(decimal exRate) : this("", exRate) { }

    public Currency(Currency copiedCurrency) : this
    (
      copiedCurrency.Name,
      copiedCurrency.ExRate
    )
    { }

    public Currency Copy() => new(this);

    public override string ToString() => $"{Name} = {ExRate} UAH";

    private void SetExchangeRate(decimal value)
    {
        Errors.CheckForRangeError(value, "exchange rate", exRate => exRate is > 0, "(> 0)");
        exRate = value;
    }
}
