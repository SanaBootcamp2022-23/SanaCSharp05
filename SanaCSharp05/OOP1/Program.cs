using OOP1;

//TESTING CLASSES Airplane.cs AND Date.cs
Date startDate = new Date(2020, 11, 4, 15, 30);// using constructor with parameteres
Date finishDate = new Date(startDate);//using copy contructor
finishDate.SetHour(22);//Changing finish hour
Airplane airbus = new Airplane("Tokyo", "Berlin", startDate, finishDate);// using constructor with parameteres
Airplane boeing = new Airplane(airbus);//using copy contructor

//Print info before changes
airbus.PrintInfo(); 
boeing.PrintInfo();

boeing.SetFinishCity("Kyiv"); //Changing finish city to Kyiv
boeing.SetStartDate(2020, 11, 4, 12, 00); //Changing start date of fly
airbus.SetStartCity("London");//Changing start city to London

//Print info after changes
airbus.PrintInfo();
boeing.PrintInfo();

//Print total time of fly using another methods GetStartCity and GetFinishCity
Console.WriteLine($"\n\nTotal fly time from {airbus.GetStartCity()} to {airbus.GetFinishCity()} " +
    $": {airbus.GetTotalTime(startDate, finishDate)}");

Console.WriteLine($"Is arriving today? {boeing.IsArrivingToday(startDate, finishDate)}");// Print bool value is arriving today
Console.WriteLine("\n\n\n\n\n\n\n");



//TESTING CLASSES Product.cs AND Currency.cs
Currency zloty = new Currency("Zloty", 8.3m); // using constructor with parameteres
Currency dollars = new Currency(zloty);//using copy contructor
dollars.SetNameCurrency("Dollars");//Set new name of currency
dollars.SetExRate(40.1m);//Set new ex rate to new currency
dollars.PrintFullCurrency();//Print information about new currency
Product drink = new Product("Fanta", 2, zloty, 45, "Cola Europe Ltd.", 0.85);// using constructor with parameteres
Product drinkNew = new Product(drink);//using copy contructor

//Print info before changes
drink.PrintInfo();
drinkNew.PrintInfo();

drinkNew.SetName("Sprite");// Set name to Sprite
drinkNew.SetPrice(1.75m);//Set new price
drinkNew.SetCost("Euro", 0.12m);// Set new cost

//Print info after changes
drink.PrintInfo();
drinkNew.PrintInfo();

Console.WriteLine($"Price of product in UAH: {drink.GetPriceInUAH()}");//Getting price of product in UAH
Console.WriteLine($"Total price of product in UAH: {drink.GetTotalPriceInUAH()}");//Getting total price of product in UAH
Console.WriteLine($"Total weight of product: {drink.GetTotalWeight()}");//Getting total weight of product

