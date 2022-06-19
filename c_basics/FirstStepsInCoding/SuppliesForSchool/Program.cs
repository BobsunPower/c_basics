using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((double.Parse(Console.ReadLine()) * 5.8 + double.Parse(Console.ReadLine()) * 7.2 + double.Parse(Console.ReadLine()) * 1.2) * ((100 - double.Parse(Console.ReadLine())) / 100));
        }
    }
}
