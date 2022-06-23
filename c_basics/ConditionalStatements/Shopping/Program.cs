using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());;
            double sum = gpu * 250 + gpu * 250 * 0.35 * cpu + gpu * 250 * 0.1 * ram;
            if (gpu > cpu) {double discount = sum * 0.15; sum -= discount;}
            if (budget >= sum) {Console.WriteLine($"You have {budget - sum:f2} leva left!");}
            else {Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
            }
        }
    }
}
