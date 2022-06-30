using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int max = int.MinValue;
            while (n != "Stop") {int num = int.Parse(n); if (num > max) {max = num;} n = Console.ReadLine();}
            Console.WriteLine(max);
        }
    }
}
