using OOP1;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Date startDate = new Date(2023, 2, 1, 12, 00);
        Date finishtDate = new Date(2023, 5, 1, 16, 30);
        Airplane plane = new("Одеса", "Варшава", new Date(2023, 2, 3, 08, 20), new Date(2023, 2, 3, 16, 30));
        Console.WriteLine($"{plane}");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(new Airplane("Харків", "Лондон", new Date(2022, 12, 19, 9, 30), new Date(2022, 12, 21, 15, 20)).ToString());
        Console.WriteLine("--------------------------------");
        Console.WriteLine(new Product("Laptop", 1000.00, new("Euro", 37), 5, "Lenovo", 1100).ToString());
    }
}
