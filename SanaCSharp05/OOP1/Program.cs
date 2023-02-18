using System.Text;
using OOP1;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Date startDate = new Date(2023, 02, 18, 11, 0);
Date finishDate = new Date(2023, 02, 18, 15, 30);
Airplane airplane = new Airplane("Kyiv", "New Yourk", startDate, finishDate);
Console.WriteLine($"Сумарний час подорожі у хвилинах: {airplane.GetTotalTime()}");
Console.WriteLine($"Відправлення і прибуття в один і той же день?: {airplane.IsArrivingToday()}");

Currency usd = new Currency("USD", 40);
Product iphone = new Product("Iphone",  575, usd, 5, "Apple", 300);

Console.WriteLine($"Ціну одиниці товару в гривнях: {iphone.GetPriceInUAH()}");
Console.WriteLine($"Загальна вартість усіх наявних на складі товарів даного виду: {iphone.GetTotalPriceInUAH()}");
Console.WriteLine($"Загальна вагу усіх товарів на складі даного виду: {iphone.GetTotalWeight()}");