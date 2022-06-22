using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            Console.WriteLine($"{time / 60}:{time % 60:d2}");
        }
    }
}
