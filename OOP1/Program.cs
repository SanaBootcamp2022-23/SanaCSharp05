using OOP1;

# region Airplanes
static void PrintAirplaneDetails(Airplane airplane, string name = "Plane")
{
    Console.WriteLine($"\n{name}:\n\tFrom: {airplane.StartCity}\n\tTo: {airplane.FinishCity}" +
    $"\n\tTakeoff: {airplane.StartDate}\n\tLanding: {airplane.FinishDate}" +
    $"\n\tTotal time: {airplane.GetTotalTime()} minutes" +
    $"\n\tIs arriving today: {(airplane.IsArrivingToday() ? "Yes" : "No")}");
}

Airplane airplane1 = new("Washington DC", "California", new(2023, 01, 30, 14, 45), new(2023, 01, 30, 19, 12));
Airplane airplane2 = airplane1.Copy();
airplane2.StartCity = "";
airplane2.FinishCity = "Sydney";
airplane2.StartDate = airplane2.FinishDate.Copy();
airplane2.StartDate.Minutes = 71;
airplane2.FinishDate = new(2023, 01, 31, 22, 57);

PrintAirplaneDetails(airplane1, "Plane 1");
PrintAirplaneDetails(airplane2, "Plane 2");
#endregion

#region Products
static void PrintProductDetails(Product product, string name = "Product")
{
    Console.WriteLine($"\n{name}:\n\tName: {product.Name}\n\tProducer: {product.Producer}" +
        $"\n\tPrice: {product.Price} {product.Cost.Name} ({product.Cost.ExRate})\n\tPrice in UAH: {product.GetPriceInUAH()}" +
        $"\n\tWeight: {product.Weight} KGs\n\tQuantity: {product.Quantity} pieces" +
        $"\n\tTotal price: {product.GetTotalPriceInUAH()} UAH\n\tTotal weight: {product.GetTotalWeight()} KGs");
}

Product product1 = new("Chair", 25, new("USD", 36.6500), 12, "LTD Chairmans", 1.25);
Product product2 = product1.Copy();
product2.Name = "New Chair";
product2.Price = 27.99;
product2.Cost = new("GBP", 46.5120);
product2.Quantity = 13;
product2.Weight = 0.97;

PrintProductDetails(product1, "Product 1");
PrintProductDetails(product2, "Product 2");
#endregion