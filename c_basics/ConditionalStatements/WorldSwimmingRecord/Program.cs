using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double time = meters * double.Parse(Console.ReadLine()) + Math.Floor(meters / 15) * 12.5;
            if (record > time) {Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");}
            else {Console.WriteLine($"No, he failed! He was {time - record:f2} seconds slower.");}
        }
    }
}
