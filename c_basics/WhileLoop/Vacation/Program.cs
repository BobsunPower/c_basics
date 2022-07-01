using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int days = 0; int spended = 0;
            while (budget < vacation) {string cmd = Console.ReadLine(); double money = double.Parse(Console.ReadLine()); days++;
                if (cmd == "save")
                {budget += money; spended = 0;}
                else {budget -= money; spended++;
                    if (spended == 5) {break;}}
                if (budget < 0) {budget = 0;}}
            if (budget >= vacation) {Console.WriteLine($"You saved the money for {days} days.");}
            else {Console.WriteLine($"You can't save the money.\n{days}");            }
        }
    }
}
