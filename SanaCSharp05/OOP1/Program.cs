using OOP1;
using System.Runtime.Remoting;
using System.Text;

internal class Program
{
    private static void Main(string[] args) { 
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Product x = new Product();
        Date dateStock = new Date();
        Date dateParam1 = new Date(2023, 01, 09, 06, 41);
        Date dateParam2 = new Date(2008, 10, 11, 09, 15);
        Airplane airplaneStock = new Airplane();
        Airplane airplaneParam1 = new Airplane("Zhytomyr", "Korosten'", new Date(2020, 01, 19, 15, 30), new Date(2020, 01, 21, 11, 45));
        Airplane airplaneParam2 = new Airplane("Borodyanka", "Kyiv", new Date(2022, 05, 08, 09, 14), new Date(2022, 05, 08, 09, 14));
        Currency USD = new Currency();
        Currency EUR = new Currency("Euro", 40.35);
        Currency GBP = new Currency("British Pound", 44.94);
        Product GPU = new Product();
        Product phone = new Product("iPhone 12", 650, new Currency(), 50, "Apple", 0.164);
        Product game = new Product("DIRT Rally 2.0", 20, GBP, 1000, "Codemasters", 0.1);
        Product phoneCopy = new Product(phone);
        Console.WriteLine(phone.Cost.ExRate);
        string price = x.GetPriceInUAH(game);
        Console.WriteLine(price);
    }
}