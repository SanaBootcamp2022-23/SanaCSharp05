using OOP1.classes.Airplane;
using OOP1.classes.Products;

try
{
    Date date1 = new Date(2023, 12, 22, 14, 30);
    Date date2 = new Date(2023, 12, 23, 22, 33);
    var airplane = new Airplane("1", "2", date1, date2);
    Console.WriteLine(airplane.GetTotalTime());
    Console.WriteLine(airplane.IsArrivingToday());

    Product product= new Product();
    Console.WriteLine();
    Console.WriteLine(product.GetPriceInUAH());
    Console.WriteLine(product.GetTotalPriceInUAH());
    Console.WriteLine(product.GetTotalWeight());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}