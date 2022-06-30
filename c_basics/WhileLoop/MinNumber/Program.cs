using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int min = int.MaxValue;
            while (n != "Stop") { int num = int.Parse(n); if (num < min) { min = num; } n = Console.ReadLine(); }
            Console.WriteLine(min);
        }
    }
}
