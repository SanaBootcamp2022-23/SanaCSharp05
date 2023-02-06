using OOP1AirplaneClassLibrary;
using OOP1ProductClassLibrary;

namespace OOP1Program;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("The OOP1 Program\n");

        // Airplane
        Console.WriteLine("Airplane:\n");

        var startDate = new Date();
        var endDate = new Date(16, 24);

        var airplane = new Airplane("Tokio", startDate, endDate);

        Console.WriteLine(airplane.ToString());

        // Product
        Console.WriteLine("\n\nProduct:\n");

        var product = new Product();

        Console.WriteLine(product.ToString());
    }
}