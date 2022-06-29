using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());
            for (int i = 1; i <= jury; i++) {
                int length = Console.ReadLine().Length;
                double pts = double.Parse(Console.ReadLine());                
                points += ((length * pts) / 2);
                if (points >= 1250.5) {Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!"); return;}}
            Console.WriteLine($"Sorry, {actor} you need {1250.5 - points:f1} more!");
        }
    }
}
