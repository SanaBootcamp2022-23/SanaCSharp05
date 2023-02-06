using OOP1;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Realizing classes Airplane and Date");
        Airplane FirstTicket = new Airplane("Tokyo", "New York", new Date(2023, 2, 6, 20, 00), new Date(2023, 2, 7, 12, 45));
        Airplane SecondTicket = new Airplane("Kyiv", "London", new Date(2024, 8, 7, 20, 00), new Date(2024, 8, 8, 4, 45));
        Console.WriteLine($"Total time of First flight: {FirstTicket.GetTotalTime()} minutes");
        Console.WriteLine($"Total time of Second flight: {SecondTicket.GetTotalTime()} minutes");
        if (FirstTicket.IsArrivingToday())
            Console.WriteLine("The First flight will arrive on the same day");
        else if (SecondTicket.IsArrivingToday())
            Console.WriteLine("The Second flight will arrive on the same day");
        else
            Console.WriteLine("None of the flights will arrive on the same day");

        Product SmartPhone = new Product("Iphone", 25000, new Currency("UAH", 1), 2, "Apple", 174);
        Console.WriteLine($"The price of product in UAH: {SmartPhone.GetPriceInUAH()}");
        Console.WriteLine($"The total cost of all goods of this type available in the warehouse: {SmartPhone.GetTotalPriceInUAH()}");
        Console.WriteLine($"The total weight of all goods in the warehouse of this type: {SmartPhone.GetTotalWeight()}");
    }
}