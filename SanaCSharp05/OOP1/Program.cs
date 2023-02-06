using System.Text;

namespace OOP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Airplane travel = new Airplane("Kyiv", "New York", new Date(2024, 11, 9, 16, 55), new Date(2024, 11, 9, 19, 32));
            travel.PrintInfo();

            Product gpu = new Product("GTX 3070", 800, new Currency("USDT", 34.6), 700, "MSI", 1234);
            gpu.PrintInfoProd();

            Product cpu = new Product("i7-13700", 466.55, new Currency("EUR", 40.30), 150000, "Intel", 345);
            cpu.PrintInfoProd();

            Product cpu2= new Product("i7-13700", 466.55, new Currency("EUR", 40.30), "Intel");
            cpu2.PrintInfoProd();

            Product milk= new Product();
            milk.PrintInfoProd();
        }
    }
}