using OOP1;
using System.Net;
using System.Text;

# region Airplanes
static void ShowAirplaneDetails(Airplane airplane, string name = "Plane")
{
    Console.WriteLine($"{name}:\n\tStart city: {airplane.StartCity}\n\tFinish city: {airplane.FinishCity}" +
    $"\n\tStart date: {airplane.StartDate}\n\tFinish date: {airplane.FinishDate}" +
    $"\n\tAll time: {airplane.GetTotalTime()} minutes" +
    $"\n\tIs arrival on the same day? {(airplane.IsArrivingToday() ? "Yes" : "No")}");
}

Airplane airplane1 = new("Lviv", "Prague", new(2023, 01, 30, 12, 00), new(2023, 01, 31, 12, 00));
Airplane airplane2 = airplane1.Copy();
airplane2.StartCity = "Zhytomir";
airplane2.FinishCity = "Kyiv";
airplane2.StartDate = new(2023, 01, 30, 12, 30);
airplane2.FinishDate = new(2023, 01, 30, 22, 30);

ShowAirplaneDetails(airplane1, "Plane 1");
ShowAirplaneDetails(airplane2, "Plane 2");
#endregion

Console.WriteLine("\n------------------------------------------\n");

#region Products
static void ShowProductDetails(Product product, string name = "Product")
{
    Console.WriteLine($"{name}:\n\tName: {product.Name}" +
        $"\n\tPrice: {product.Price} {product.Cost.Name} ({product.Cost.ExRate})" +
        $"\n\tPrice in UAH: {Math.Round(product.GetUAH())}" +
        $"\n\tQuantity: {product.Quantity}" +
        $"\n\tProducer: {product.Producer}" +
        $"\n\tWeight: {product.Weight} kg" +
        $"\n\tTotal price: {Math.Round(product.GetTotalPriceUAH())} UAH");
}

Product product1 = new("Monitor", 200, new("USD", 36.73), 7, "LG", 3.1);
Product product2 = product1.Copy();
product2.Name = "TV";
product2.Price = 250.5;
product2.Cost = new("EUR", 39.84);
product2.Quantity = 4;
product2.Producer = "Samsung";
product2.Weight = 8.25;

ShowProductDetails(product1, "Product 1");
ShowProductDetails(product2, "Product 2");
#endregion