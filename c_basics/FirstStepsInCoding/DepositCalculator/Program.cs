using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months= int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine(deposit + deposit * interest / 12 * months);
        }
    }
}
