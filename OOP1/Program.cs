using OOP1;

Airplane plane1 = new Airplane("NewYork", "LosAngeles", new Date(2023, 2, 6, 11, 30), new Date(2023, 2, 6, 17, 45));
Console.WriteLine("Time: " + plane1.GetTotalTime() + " minutes");
Console.WriteLine("IsArrivingToday: " + plane1.IsArrivingToday());
Console.WriteLine("{0} - {1}", plane1.StartCity, plane1.FinishCity);
Console.WriteLine($"Start date: {plane1.StartDate.Day}.{plane1.StartDate.Month}.{plane1.StartDate.Year}  {plane1.StartDate.Hours}:{plane1.StartDate.Minutes}");

Airplane plane2 = new Airplane("Kyiv","Berlin");
plane2.StartDate = new Date(2023, 6, 9, 23);
plane2.FinishDate = new Date(2023, 6, 10, 5, 30);
Console.WriteLine();
Console.WriteLine("Time: " + plane2.GetTotalTime() + " minutes");
Console.WriteLine("IsArrivingToday: " + plane2.IsArrivingToday());
Console.WriteLine("{0} - {1}", plane2.StartCity, plane2.FinishCity);
Console.WriteLine($"Start date: {plane2.StartDate.Day}.{plane2.StartDate.Month}.{plane2.StartDate.Year}  {plane2.StartDate.Hours}:{plane2.StartDate.Minutes}");

Console.WriteLine("\n");
Currency ILS = new Currency("ILS", 10.5428);
Currency USD = new Currency("USD", 36.5686);

Product milk = new Product("Milk", 6, 150, "IsraelMilkCompany", 1, ILS);
Product bread = new Product();
bread.Name = "Bread";
bread.Quantity = 300;
bread.Cost = new Currency(USD);
bread.Weight = 0.3;
bread.Price = 4;
bread.Producer = "USABreadCompany";
Console.WriteLine("Producer: " + milk.Producer);
Console.WriteLine("Total weight: " + milk.GetTotalWeight());
Console.WriteLine("Price for one product: " + milk.GetPriceInUAH());
Console.WriteLine("Total price: " + milk.GetTotalPriceInUAH());
Console.WriteLine();
Console.WriteLine("Producer: " + bread.Producer);
Console.WriteLine("Total weight: " + bread.GetTotalWeight());
Console.WriteLine("Price for one product: " + bread.GetPriceInUAH());
Console.WriteLine("Total price: " + bread.GetTotalPriceInUAH());