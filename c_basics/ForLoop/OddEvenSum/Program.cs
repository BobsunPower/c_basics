using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0; int even = 0; int num = 0;
            for (int i = 0; i < n; i++) {num = int.Parse(Console.ReadLine());
                if (i % 2 == 0) {even += num;}
                else {odd += num;}}
            if (odd == even) {Console.WriteLine($"Yes\nSum = {odd}");}
            else {Console.WriteLine($"No\nDiff = {Math.Abs(odd - even)}");}
        }
    }
}
