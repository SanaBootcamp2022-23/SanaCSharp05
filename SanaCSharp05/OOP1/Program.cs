// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using OOP1;

class Program

    {
    public static void Main(string[] args)
    {
        Date startDate = new Date(2023, 2, 5, 17, 30);
        Date finishDate = new Date(2023, 2, 6, 12, 30);
        Airplane airplane = new Airplane("Kyiv", "Tokio", startDate, finishDate);

        Console.WriteLine("Airplane");
        Console.WriteLine("Total time: " + airplane.GetTotalTime());
        Console.WriteLine("Is arriving today: " + airplane.IsArrivingToday());

        Console.WriteLine("\n");

        Currency currency = new Currency("USD", 800);
        Product product = new Product("AppleWatch", 800, currency, 40, "Apple", 500);

        Console.WriteLine("Product & Currency");
        Console.WriteLine("Price in UAH: " + product.GetPriceInUAH());
        Console.WriteLine("Total price in UAH: " + product.GetTotalPriceInUAH());
        Console.WriteLine("Total weight: " + product.GetTotalWeight());

        Console.ReadLine();
    }
}
