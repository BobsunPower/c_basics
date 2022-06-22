using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double sum = (puzzles * 2.6)+ (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);
            int toys = puzzles + dolls + bears + minions + trucks;
            if (toys >= 50) {double discount = sum * 0.25; sum -= discount;}
            sum *= 0.9;
            if (sum >= trip) {Console.WriteLine($"Yes! {sum - trip:f2} lv left.");}
            else {Console.WriteLine($"Not enough money! {trip - sum:f2} lv needed.");
            }
        }
    }
}
