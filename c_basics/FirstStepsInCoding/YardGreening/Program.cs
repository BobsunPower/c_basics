using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = double.Parse(Console.ReadLine()) * 7.61;
            Console.WriteLine($"The final price is: {total * 0.82:f2} lv.\nThe discount is: {total * 0.18:f2} lv.");
        }
    }
}
