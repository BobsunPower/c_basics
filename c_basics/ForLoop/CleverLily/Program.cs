using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toys = 0; double gift = 0; double money = 0;
            for (int i = 1; i <= years; i++)
            {if (i % 2 == 0) {money += 10.0; gift += money - 1;}
                else{toys++;}}
            double total = gift + (toys * toyPrice);
            if (total >= washingMachine) {Console.WriteLine($"Yes! {total - washingMachine:f2}");}
            else {Console.WriteLine($"No! {washingMachine - total:f2}");}
        }
    }
}
