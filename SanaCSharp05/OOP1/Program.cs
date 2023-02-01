using ClassLibraryOOP1;

Airplane airplane = new Airplane("Zhytomyr", "Paris", new Date(1, 2, 2023), new Date(2023, 2, 2, 12, 55));

Console.WriteLine(airplane.IsArrivingToday());
Console.WriteLine(airplane.GetTotalTime());

Product product = new Product("Iphone 14", 999, new Currency("USD", 36.56M), 10, "Apple", 0.164);

Console.WriteLine(product.GetPriceInUAH());
Console.WriteLine(product.GetTotalPriceInUAH());
Console.WriteLine(product.GetTotalWeight());