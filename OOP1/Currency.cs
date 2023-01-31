using System;

namespace OOP1;
public class Currency {
    private string _name = "Undefined";
    private decimal _exRate;

    public string Name { get => _name; set => _name = value ?? "Undefined"; }
    public decimal ExRate { get => _exRate; set => _exRate = value; }

    public Currency() {}

    public Currency(string name, decimal exRate) {
        this.Name = name;
        this.ExRate = exRate;
    }

    public Currency(string name) {
        this.Name = name;
    }

    public Currency(Currency currency) {
        this.Name = currency.Name;
        this.ExRate = currency.ExRate;
    }

    public override string ToString() {
        return $"{this.Name}: {this.ExRate} UAH";
    }
}
