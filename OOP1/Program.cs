using System;

namespace OOP1;
public class Program {
    public static void Main(string[] args) {
        Date startDate = new Date(2023, 1, 31, 15, 40);
        Date finishDate = new Date(2023, 1, 31, 18, 0);
        Airplane airplane = new Airplane("Warsaw", "Milan", startDate, finishDate);

        Console.WriteLine(airplane);
        Console.WriteLine("Total time: " + airplane.GetTotalTime());
        Console.WriteLine("Is arriving today: " + airplane.IsArrivingToday());

        Console.WriteLine();

        Currency currency = new Currency("USD", 10.00m);
        Product product = new Product("MacBook Air", 1000.00m, currency, 34, "Apple", 1200);

        Console.WriteLine(product);
        Console.WriteLine("Price in UAH: " + product.GetPriceInUAH());
        Console.WriteLine("Total price in UAH: " + product.GetTotalPriceInUAH());
        Console.WriteLine("Total weight: " + product.GetTotalWeight());
    }
}
