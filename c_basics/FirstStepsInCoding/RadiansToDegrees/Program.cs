using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(double.Parse(Console.ReadLine()) * 180 / Math.PI);
        }
    }
}
