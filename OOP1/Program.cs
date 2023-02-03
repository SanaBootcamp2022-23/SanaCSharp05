// See https://aka.ms/new-console-template for more information
using OOP1;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Date startDate = new Date();
Date finishDate = new Date(2023, 5, 10);
Airplane airplane = new Airplane("Житомир", "New-York",startDate,finishDate);
Console.WriteLine($"Інформація про подорож:\n\tМіто відправлення -> {airplane.GetStartCity()}" +
 $"\n\tМісто прибуття -> {airplane.GetFinishCity()}\n\tДата відправлення -> {airplane.GetStartDate().GetYear()}" +
 $"/{airplane.GetStartDate().GetMonth()}/{airplane.GetStartDate().GetDay()}\n\tДата прибуття -> {airplane.GetFinishDate().GetYear()}/" +
 $"{airplane.GetFinishDate().GetMonth()}/{airplane.GetFinishDate().GetDay()}");


airplane.SetFinishCity("Токіо");
airplane.SetFinishDate(new Date(2023, 8, 10));
airplane.SetStartDate(new Date(2023, 7, 10));
Console.WriteLine($"\nІнформація про подорож після зміни даних:\n\tМіто відправлення -> {airplane.GetStartCity()}" +
 $"\n\tМісто прибуття -> {airplane.GetFinishCity()}\n\tДата відправлення -> {airplane.GetStartDate().GetYear()}" +
 $"/{airplane.GetStartDate().GetMonth()}/{airplane.GetStartDate().GetDay()}\n\tДата прибуття -> {airplane.GetFinishDate().GetYear()}/" +
 $"{airplane.GetFinishDate().GetMonth()}/{airplane.GetFinishDate().GetDay()}");

Console.WriteLine($"\nЗагальний час подорожі -> {airplane.GetTotalTime()} хвилин.");
Console.WriteLine($"Чи відбувся початок і кінець подорожі в один день -> {airplane.IsArrivingToday()}");
Console.WriteLine("\n----------------------------------------------------------------\n");

Product product = new Product("Apple Iphone 14", 1200, new Currency("долар", 38), 10, 0.4);
Console.WriteLine($"Інформація про товар:\n\tІм'я продукту -> {product.GetName()}\n\t" +
    $"Ціна продукту -> {product.GetPrice()}\n\tВалюта -> {product.GetCurrency().GetNameCurrency()}\n\t" +
    $"Курс валюти до гривні -> {product.GetCurrency().GetExRateCurrency()}\n\tКількість товарів на складі -> " +
    $"{product.GetQuantity()}\n\tВага товару -> {product.GetWeight()} кг.");

product.SetName("Samsung Galaxy S21 Ultra");
product.SetPrice(1300);
product.SetCurrency(new Currency("євро", 40));
product.SetQuantity(40);
product.SetWeight(0.5);



Console.WriteLine($"\nІнформація про товар після зміни даних:\n\tІм'я продукту -> {product.GetName()}\n\t" +
    $"Ціна продукту -> {product.GetPrice()}\n\tВалюта -> {product.GetCurrency().GetNameCurrency()}\n\t" +
    $"Курс валюти до гривні -> {product.GetCurrency().GetExRateCurrency()}\n\tКількість товарів на складі -> " +
    $"{product.GetQuantity()}\n\tВага товару -> {product.GetWeight()} кг.");

Console.WriteLine($"Ціна одиниці товару в гривнях -> {product.GetPriceInUAH()} грн.");
Console.WriteLine($"Загальна вартість усіх наявних товарів на складі даного виду -> {product.GetTotalPriceInUAH()} грн.");
Console.WriteLine($"Загальна вага усіх наявних товарів на складі даного виду -> {product.GetTotalWeight()} кг.");