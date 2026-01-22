using System;

namespace Laboratory5__2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Точка 1:");
            Koord latitude1 = new Koord();
            Console.WriteLine("Ввод для широты");
            latitude1.Read();
            Koord longitude1 = new Koord();
            Console.WriteLine("Ввод для долготы");
            longitude1.Read();
            Console.WriteLine("Точка 2:");
            Koord latitude2 = new Koord();
            Console.WriteLine("Ввод для широты");
            latitude2.Read();
            Koord longitude2 = new Koord();
            Console.WriteLine("Ввод для долготы");
            longitude2.Read();
            Koord calculate = new Koord();
            calculate.Calculate(latitude1, longitude1, latitude2, longitude2);
            calculate.Display();
        }
    }
}