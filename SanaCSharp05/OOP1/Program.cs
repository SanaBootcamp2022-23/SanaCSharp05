using OOP1;

class Program
{


    static void Main(string[] args)
    {

        Airplane testAirplane = new Airplane("Zhytomyr", "Dnipro", 2022, 12, 28, 2022, 12, 28, 21, 13, 23, 44);
        testAirplane.GetTotalInfo();

        Console.WriteLine();

        Product testProduct = new Product("Картопля", 2, "Доллар", (float)37.45, 1, "ТОВ Сонце", 10);
        testProduct.GetTotalInfo();
    }
}
