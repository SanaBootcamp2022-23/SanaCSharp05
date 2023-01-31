using OOP1;

Console.WriteLine("Example of work Airplane and Date classes");
Console.WriteLine("Create airplane obj");
Airplane Airplane = new Airplane("Kiev", "Warshava", new Date(2023, 4, 9, 12, 30), new Date(2023, 4, 9, 15, 30));
Console.WriteLine("Check method GetTotalTime");
Console.WriteLine($"{Airplane.GetTotalTime()} minuts");
Console.WriteLine("Check method idArrivingToday");
Console.WriteLine(Airplane.IsArrivingToday(Airplane));
Console.WriteLine("Example of work Product and Currency classes");
Console.WriteLine("Create product obj");
Product product = new Product("IMac", 210000.0, new Currency(), 10, "Apple", 6.6);
Console.WriteLine("Check method GetPriceInUAH");
Console.WriteLine(product.GetPriceInUAH());
Console.WriteLine("Check method GetTotalPriceInUAH");
Console.WriteLine(product.GetTotalPriceInUAH());
Console.WriteLine("Check method GetTotalWeight");
Console.WriteLine(product.GetTotalWeight());