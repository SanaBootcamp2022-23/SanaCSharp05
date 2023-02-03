using OOP1;

try
{
    WriteLine();

    List<Airplane> flights = new()
    {
        new("Washington DC", "Los Angeles CA", new(2023, 01, 31, 12, 30), new(2023, 01, 31, 15, 04)),
        new("Warsaw", "Milan", new(DateTime.Now), new(DateTime.Now.AddHours(3))),
        new("Paris", "Amsterdam", new(DateTime.Now), new(DateTime.Now.AddHours(1).AddMinutes(20))),
        new("Tel Aviv", "London", new(DateTime.Now), new(DateTime.Now.AddHours(4).AddMinutes(25))),
    };

    WriteLine("Flights: \n");
    flights.ForEach(flight =>
    {
        WriteLine($"\t{flight.ToString().PadLeft(100)}");
    });

    WriteLine();

    Currency usd = new("USD", 40.00m);
    Currency eur = new("EUR", 41.00m);
    Currency uah = new();

    List<Product> products = new()
    {
        new("MacBook Air M2", 1199.00M, usd, 15, "Apple", 1.25),
        new("MacBook Pro M2", 1349.00M, eur, 4, "Apple", 1.4),
        new("2K 27\" Monitor", 15_999.00M, uah, 30, "Xiaomi", 6.53),
        new("K2 Keyboard", 79.00M, usd, 7, "Keychron", 0.663),
    };

    WriteLine("Products: \n");
    products.ForEach(product =>
    {
        WriteLine($"\t{product}");
        WriteLine($"\t\t Price in UAH: {product.GetPriceInUAH():N2}");
        WriteLine($"\t\t Total weight: {product.GetTotalWeight()} kg");
        WriteLine($"\t\t Total price in UAH: {product.GetTotalPriceInUAH():N2}");

        WriteLine();
    });
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

