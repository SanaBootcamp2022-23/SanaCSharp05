using OOP1;

Airplane airplane1 = new Airplane("Zhytomyr", "Kyiv", new Date(2023, 2, 3, 17, 20), new Date(2023, 2, 3, 23, 45));
AirplaneOutput(airplane1);
Console.WriteLine($"\nTotal time in minutes: {airplane1.GetTotalTime()}");
Console.WriteLine($"Is arriving today = {airplane1.IsArrivingToday()}\n");

Product product1 = new Product("Processor", 150, new Currency("US", 42.5), 50, "Intel", 0.150);

ProductOutput(product1);

Console.WriteLine($"\nPrice 1 product in UAH = {product1.GetPriceInUAH()} grn");
Console.WriteLine($"Price all product in UAH = {product1.GetTotalPriceInUAH()} grn");
Console.WriteLine($"Weight of all product at storage: {product1.GetTotalWeight()} kg");

//Airplane airplane2 = new Airplane();

//AirplaneInput(airplane2);

//AirplaneOutput(airplane2);

void AirplaneInput(Airplane airplane)
{
    int checkRightNumber;
    Console.WriteLine("Input start city: ");
    airplane.StartCity = Console.ReadLine();
    Console.WriteLine("Input finish city: ");
    airplane.FinishCity = Console.ReadLine();
    Console.WriteLine("Input start date: ");
    Console.WriteLine("Year: ");
    CheckAndWriteNumber(out checkRightNumber, "year");
    airplane.StartDate.Year = checkRightNumber;

    Console.WriteLine("Month: ");
    CheckAndWriteNumber(out checkRightNumber, "month");
    airplane.StartDate.Month = checkRightNumber;

    Console.WriteLine("Day: ");
    CheckAndWriteNumber(out checkRightNumber, "day");
    airplane.StartDate.Day = checkRightNumber;

    Console.WriteLine("Hour: ");
    CheckAndWriteNumber(out checkRightNumber, "hours");
    airplane.StartDate.Hours = checkRightNumber;

    Console.WriteLine("Minute: ");
    CheckAndWriteNumber(out checkRightNumber, "minutes");
    airplane.StartDate.Minutes = checkRightNumber;

    Console.WriteLine("Input finish date: ");
    Console.WriteLine("Year: ");
    CheckAndWriteNumber(out checkRightNumber, "year");
    airplane.FinishDate.Year = checkRightNumber;

    Console.WriteLine("Month: ");
    CheckAndWriteNumber(out checkRightNumber, "month");
    airplane.FinishDate.Month = checkRightNumber;

    Console.WriteLine("Day: ");
    CheckAndWriteNumber(out checkRightNumber, "day");
    airplane.FinishDate.Day = checkRightNumber;

    Console.WriteLine("Hour: ");
    CheckAndWriteNumber(out checkRightNumber, "hours");
    airplane.FinishDate.Hours = checkRightNumber;

    Console.WriteLine("Minute: ");
    CheckAndWriteNumber(out checkRightNumber, "minutes");
    airplane.FinishDate.Minutes = checkRightNumber;
}
void AirplaneOutput(Airplane airplane)
{
    Console.WriteLine($"City of departure: {airplane.StartCity}");
    Console.WriteLine($"City of arrival: {airplane.FinishCity}");
    Console.WriteLine($"Date of departure: {airplane.StartDate.Day}.{airplane.StartDate.Month}.{airplane.StartDate.Year}  {airplane.StartDate.Hours}:{airplane.StartDate.Minutes}");
    Console.WriteLine($"Date of arrival: {airplane.FinishDate.Day}.{airplane.FinishDate.Month}.{airplane.FinishDate.Year}  {airplane.FinishDate.Hours}:{airplane.FinishDate.Minutes}");
}

void ProductInput(Product product)
{
    int checkRightNumber;
    Console.WriteLine("Input name of product: ");
    product.Name = Console.ReadLine();
    Console.WriteLine("Input price of 1 product: ");
    CheckAndWriteNumber(out checkRightNumber, "number");
    product.Price = checkRightNumber;
    Console.WriteLine("Input Name of currency: ");
    product.Cost.Name = Console.ReadLine();
    Console.WriteLine("Input exchange rate: ");
    product.Cost.ExRate = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input quantity of product: ");
    CheckAndWriteNumber(out checkRightNumber, "number");
    product.Quantity = checkRightNumber;
    Console.WriteLine("Input name of producer: ");
    product.Producer = Console.ReadLine();
    Console.WriteLine("Input weight of product: ");
    product.Weight = Convert.ToDouble(Console.ReadLine());
}
void ProductOutput(Product product)
{
    Console.WriteLine($"Name of product: {product.Name}");
    Console.WriteLine($"Price 1 product: {product.Price}");
    Console.WriteLine($"Currency of price:\nName: {product.Cost.Name}\nExchange rate: {product.Cost.ExRate}");
    Console.WriteLine($"Quantity of product: {product.Quantity}");
    Console.WriteLine($"Name of producer: {product.Producer}");
    Console.WriteLine($"Weight of 1 product: {product.Weight} kg");
}

void CheckAndWriteNumber(out int number, string mode) // mode have 6 operating mode: number, year, month, day, hours, minutes
{
    bool isRightNumber;
    do
    {
        isRightNumber = int.TryParse(Console.ReadLine(), out number);
        switch (mode)
        {
            case "number":
                {
                    if (number < 0)
                        isRightNumber = false;
                    if (!isRightNumber)
                    {
                        Console.Write("ERROR!!!\n");
                    }
                }
                break;
            case "year":
                {
                    if (number < 0)
                        isRightNumber = false;
                    if (!isRightNumber)
                    {
                        Console.Write("ERROR!!!\n");
                    }
                }
                break;
            case "month":
                {
                    if (number < 0 || number > 12)
                        isRightNumber = false;
                    if (!isRightNumber)
                    {
                        Console.Write("ERROR!!!\n");
                    }
                }
                break;
            case "day":
                {
                    if (number < 1 || number > 31)
                        isRightNumber = false;
                    if (!isRightNumber)
                    {
                        Console.Write("ERROR!!!\n");
                    }
                }
                break;
            case "hours":
                {
                    if (number < 0 || number > 23)
                        isRightNumber = false;
                    if (!isRightNumber)
                    {
                        Console.Write("ERROR!!!\n");
                    }
                }
                break;
            case "minutes":
                {
                    if (number < 0 || number > 59)
                        isRightNumber = false;
                    if (!isRightNumber)
                    {
                        Console.Write("ERROR!!!\n");
                    }
                }
                break;
        }
    } while (!isRightNumber);
}