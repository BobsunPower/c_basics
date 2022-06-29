using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {int add = int.Parse(Console.ReadLine()); sum += add; if (add > max) {max = add;}}
            if (max == sum - max) { Console.WriteLine($"Yes\nSum = {max}"); }
            else {Console.WriteLine($"No\nDiff = {Math.Abs(sum - (max * 2))}");}
        }
    }
}
