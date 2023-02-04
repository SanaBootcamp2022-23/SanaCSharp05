using ClassLibrary;

Date startDate = new Date(2023, 12, 10, 12, 0);
Date finishDate = new Date(2023, 12, 11, 15, 45);
Airplane airplane = new Airplane("Warsaw", "Sydney", startDate, finishDate);
Console.WriteLine($"Total time (minutes): {airplane.GetTotalTime()}");
Console.WriteLine($"Plane arrives at the same day: {airplane.IsArrivingToday()}");

Console.WriteLine();

Currency usd = new Currency( currencyName: "USD", currencyExRate: 38);
Product prod = new Product(productName: "Milk", productPrice: 1, currencyCost: usd, productQuantity: 5, productProducer: "Ukraine", productWeight: 1.025);

Console.WriteLine($"Price in UAH: {prod.GetPriceInUAH()}");
Console.WriteLine($"Total Price in UAH: {prod.GetTotalPriceInUAH()}");
Console.WriteLine($"Total weight: {prod.GetTotalWeight()}");
