using OOP1;

Currency uah = new Currency("UAH", 1);
Product bread = new Product("Bread", 10, uah, 100, "Bakery Inc.", 0.5);

Console.WriteLine("Product Name: " + bread.Name);
Console.WriteLine("Product Price: " + bread.Price + " " + bread.Cost.GetName());
Console.WriteLine("Product Quantity: " + bread.Quantity);
Console.WriteLine("Product Producer: " + bread.Producer);
Console.WriteLine("Product Weight: " + bread.Weight + " kg");

Console.WriteLine("Total Price of Bread in UAH: " + bread.GetTotalPriceInUAH());
Console.WriteLine("Total Weight of Bread: " + bread.GetTotalWeight() + " kg");

bread.Price = 12;
Console.WriteLine("Updated Price: " + bread.Price + " " + bread.Cost.GetName());

Currency myCurrency = new Currency("USD", 39.5);

Console.WriteLine("\nCurrency Name: " + myCurrency.GetName());
Console.WriteLine("Currency Exchange Rate: " + myCurrency.GetExRate());

myCurrency.SetExRate(40.0);
Console.WriteLine("Currency Exchange Rate after modification: " + myCurrency.GetExRate());

Date myDate = new Date(2023, 4, 2);
Console.WriteLine("\nDate: " + myDate.Day + "/" + myDate.Month + "/" + myDate.Year);
myDate.Day = 10;
myDate.Month = 05;
myDate.Year = 2024;
Console.WriteLine("Date after modification: " + myDate);

Date start = new Date(2023, 2, 5);
Date end = new Date(2023, 2, 6);
Airplane flight = new Airplane("Kyiv", "New York", start, end);

Console.WriteLine("\nFirst Flight: Kyiv - New York");
Console.WriteLine("Start city: " + flight.StartCity);
Console.WriteLine("Finish city: " + flight.FinishCity);
Console.WriteLine("Start date UTC: " + flight.StartDate);
Console.WriteLine("Finish date UTC: " + flight.FinishDate);
Console.WriteLine("Arriving today: " + flight.IsArrivingToday());
Console.WriteLine("Total Time UTC: " + flight.GetTotalTime());

Date start2 = new Date(2022, 1, 16, 15, 30);
Date end2 = new Date(2022, 1, 16, 17, 40);
Airplane flight2 = new Airplane("Kyiv", "Cologne", start2, end2);

Console.WriteLine("\nSecond Flight: Kyiv - Cologne");
Console.WriteLine("Start city: " + flight2.StartCity);
Console.WriteLine("Finish city: " + flight2.FinishCity);
Console.WriteLine("Start date UTC: " + flight2.StartDate);
Console.WriteLine("Finish date UTC: " + flight2.FinishDate);
Console.WriteLine("Arriving today: " + flight2.IsArrivingToday());
Console.WriteLine("Total Time UTC: " + flight2.GetTotalTime());

Console.ReadLine();