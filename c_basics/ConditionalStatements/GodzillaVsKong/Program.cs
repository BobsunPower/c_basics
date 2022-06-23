using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothes = people * double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            if (people >= 150) {double discount = clothes * 0.1; clothes -= discount;}
            double expenses = decor + clothes;
            if (expenses > budget) {Console.WriteLine($"Not enough money!\nWingard needs {expenses - budget:f2} leva more.");}
            else {Console.WriteLine($"Action!\nWingard starts filming with {budget - expenses:f2} leva left.");
            }
        }
    }
}
