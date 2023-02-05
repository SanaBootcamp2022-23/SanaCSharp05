namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane(new Date(2023, 1, 2, 10, 0),
                new Date(2023, 1, 2, 15, 0));
            Console.WriteLine("{0}", airplane.GetTotalTime());
            Console.WriteLine("{0}", airplane.IsArrivingToday());
            
            Product product = new Product("Apple",
                10,new Currency("UAH", 40),
                20,10);
            Console.WriteLine("{0}", product.GetPriceInUAH());
            Console.WriteLine("{0}", product.GetTotalPriceInUAH());
            Console.WriteLine("{0}", product.GetTotalWeight());
        }
    }
}