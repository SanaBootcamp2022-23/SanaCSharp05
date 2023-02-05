using OOP1;

Airplane airplane = new Airplane("Kyiv","Paris",new Date(2023,10,2,10,30,0), new Date(2023,11,2,2,15,0));
Console.WriteLine($"From: {airplane.startCity}\nTo: {airplane.finishCity}");
Console.WriteLine($"Time of flight: {airplane.GetTotalTime()} min.");
Console.WriteLine($"Is flight ends in the same day : {airplane.IsArrivingToday()}");

airplane.finishCity = "Berlin";
airplane.finishDate = new Date(2023, 10, 2, 23, 40, 0);

Console.WriteLine("\nThe flight has changed its finish point\n");
Console.WriteLine($"From: {airplane.startCity}\nTo: {airplane.finishCity}");
Console.WriteLine($"Time of flight: {airplane.GetTotalTime()} min.");
Console.WriteLine($"Is flight ends in the same day : {airplane.IsArrivingToday()}");

Console.WriteLine("\n----------------------------\n");

Currency dollars = new Currency("Dollar", 40);
Console.WriteLine($"1 {dollars.name} => {dollars.exRate} UAH\n");
Product jacket = new Product("Jacket",10,dollars,2,"Nike",1);
Console.WriteLine($"Name of product: {jacket.name}");    
Console.WriteLine($"Price: {jacket.price} of \"{jacket.cost.name}\"");
Console.WriteLine($"Quantity in store: {jacket.quantity}");
Console.WriteLine($"Producer: {jacket.producer}");
Console.WriteLine($"Weight: {jacket.weight} kg");

Console.WriteLine("");


Console.WriteLine($"Price in UAH: {jacket.GetPriceInUAH()} UAH");
Console.WriteLine($"Total price in UAH: {jacket.GetTotalPriceInUAH()} UAH");
Console.WriteLine($"Total weight of product in store: {jacket.GetTotalWeight()} kg");