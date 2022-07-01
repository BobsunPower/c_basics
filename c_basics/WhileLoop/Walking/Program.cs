using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000; int steps = 0;
            while (steps < goal) {string add = Console.ReadLine();
                if (add != "Going home") {int last = int.Parse(add); steps += last;}
                else {int more = int.Parse(Console.ReadLine()); steps += more; break;}}
            if (steps >= goal) {Console.WriteLine($"Goal reached! Good job!\n{steps - goal} steps over the goal!");}
            else {Console.WriteLine($"{goal - steps} more steps to reach goal.");}
        }
    }
}
