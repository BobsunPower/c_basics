using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(((double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine())) * 0.001) * (1 - double.Parse(Console.ReadLine()) / 100));
        }
    }
}
