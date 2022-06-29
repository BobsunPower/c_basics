using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] lst = new double[5];
            for (int i = 0; i < n; i++)
            {int num = int.Parse(Console.ReadLine());
                if (num < 200) { lst[0]++;}
                else if (num < 400) {lst[1]++;}
                else if (num < 600) {lst[2]++;}
                else if (num < 800) {lst[3]++;}
                else {lst[4]++;}}
            Console.WriteLine($"{(lst[0] / n) * 100:f2}%\n{(lst[1] / n) * 100:f2}%\n{(lst[2] / n) * 100:f2}%\n{(lst[3] / n) * 100:f2}%\n{(lst[4] / n) * 100:f2}%");
        }
    }
}
