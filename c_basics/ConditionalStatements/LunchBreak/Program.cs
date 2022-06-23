using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int time = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());
            double free = rest - rest * 0.125 - rest * 0.25;
            if (free >= time) {Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(free - time)} minutes free time.");}
            else {Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(time - free)} more minutes.");}
        }
    }
}
