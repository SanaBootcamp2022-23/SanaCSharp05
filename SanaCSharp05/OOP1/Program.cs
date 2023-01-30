using System.Text;

namespace OOP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Приклад роботи класів Airplane та Date".ToUpper());
            Console.WriteLine("Створення об'єкту Airplane:");
            Console.WriteLine("Airplane airplane = new Airplane(\"Київ\", \"Вінниця\", new Date(3, 1, 2023, 6, 30), new Date(3, 1, 2023, 8, 30))");
            Airplane airplane = new Airplane("Київ", "Вінниця", new Date(3, 1, 2023, 6, 30), new Date(3, 1, 2023, 8, 30));
            Console.WriteLine("Виклик методу IsArrivingToday:");
            Console.WriteLine(airplane.IsArrivingToday());
            Console.WriteLine("Виклик методу GetTotalTime:");
            Console.WriteLine(airplane.GetTotalTime());
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Приклад роботи класів Product та Currency".ToUpper());
            Console.WriteLine("Створення об'єкту Product:");
            Product product = new Product("Телефон", 270, new Currency("USD", 36.73m), "Xiaomi", 0.25, 20);
            Console.WriteLine("Product product = new Product(\"Телефон\", 270, new Currency(\"USD\", 36.73m), \"Xiaomi\", 0.25, 20)");
            Console.WriteLine("Виклик методу GetPriceInUAH:");
            Console.WriteLine(product.GetPriceInUAH());
            Console.WriteLine("Виклик методу GetTotalPriceInUAH:");
            Console.WriteLine(product.GetTotalPriceInUAH());
            Console.WriteLine("Виклик методу GetTotalWeight:");
            Console.WriteLine(product.GetTotalWeight());
        }
    }
}