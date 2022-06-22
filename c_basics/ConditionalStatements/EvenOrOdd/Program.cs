using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            if (double.Parse(Console.ReadLine()) % 2 == 0) {Console.WriteLine("even");}
            else {Console.WriteLine("odd");}
        }
    }
}
