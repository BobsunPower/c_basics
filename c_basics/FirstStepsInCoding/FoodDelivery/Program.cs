using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((double.Parse(Console.ReadLine()) * 10.35 + double.Parse(Console.ReadLine()) * 12.4 + double.Parse(Console.ReadLine()) * 8.15) * 1.2 + 2.5);
        }
    }
}
