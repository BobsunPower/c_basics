using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double expenses = (double.Parse(Console.ReadLine()) + 2) * 1.5 + double.Parse(Console.ReadLine()) * 1.1 * 14.5 + double.Parse(Console.ReadLine()) * 5 + 0.4;
            Console.WriteLine(expenses + (expenses * 0.3 * double.Parse(Console.ReadLine())));
        }
    }
}