using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fst = 0; int snd = 0;
            for (int i = 0; i < n; i++) {fst += int.Parse(Console.ReadLine());}
            for (int i = 0; i < n; i++) {snd += int.Parse(Console.ReadLine());}
            if (fst == snd) {Console.WriteLine($"Yes, sum = {fst}");}
            else {Console.WriteLine($"No, diff = {Math.Abs(fst - snd)}");};
        }
    }
}
