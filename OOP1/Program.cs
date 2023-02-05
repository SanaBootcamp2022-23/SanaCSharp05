
using System.Text;
using OOP1;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
Date startDate = new Date(2023, 2, 5, 14, 55);
Date finishDate = new Date(2023, 2, 6, 15, 50);
Airplane airplane = new Airplane("Київ", "Лондон", startDate, finishDate);
airplane.StartDate = new Date(2023, 2, 5, 19, 40);
airplane.FinishCity = "Париж";
Console.WriteLine($"Рейс: {airplane.StartCity} - {airplane.FinishCity}");
Console.WriteLine($"Місто відправлення - {airplane.StartCity}\n" +
    $"Дата відправлення - {airplane.StartDate.FullDate()}\n" +
    $"Місто прибуття - {airplane.FinishCity} \n" +
    $"Дата прибуття - {airplane.FinishDate.FullDate()}\n" +
    $"Загальний час польоту у хвилинах - {airplane.GetTotalTime()} \n" +
    $"Зліт та посадка відбудуться в один день - {(airplane.IsArrivingToday() ? "Так" : "Ні")}");
Console.WriteLine();

Currency USD = new Currency("USD", 40);
Product product = new Product("Ноутбук", 1000, USD, 10, "Acer", 3);
product.Price = 1200;
product.Weight = 2.8;
product.Cost.ExRate = 39.8;

Console.WriteLine("Дані товару:");
Console.WriteLine($"Назва товару - {product.Name} \n" +
    $"Ціна - {product.Price} {product.Cost.Name} \n" +
    $"Кількість на складі - {product.Quantity} \n" +
    $"Бренд - {product.Producer}\n" +
    $"Вага - {product.Weight} \n" +
    $"Варість в гривнях - {product.GetPriceInUAH()} UAH\n" +
    $"Загальна вартість всього товару в гривнях - {product.GetTotalPriceInUAH()}  UAH\n" +
    $"Загальна вага -  {product.GetTotalWeight()}");
