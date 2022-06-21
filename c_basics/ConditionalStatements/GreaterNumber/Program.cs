using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }
    }
}
