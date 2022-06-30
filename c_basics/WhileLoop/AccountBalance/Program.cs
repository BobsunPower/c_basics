using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string add = Console.ReadLine(); double sum = 0;
            while (add != "NoMoreMoney")
            {double money = double.Parse(add);
                if (money < 0) {Console.WriteLine("Invalid operation!"); break;}
                else {Console.WriteLine($"Increase: {money:f2}"); sum += money;}
                add = Console.ReadLine();}
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}