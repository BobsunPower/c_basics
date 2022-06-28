using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue; 
            double min = double.MaxValue; 
            double cnt = 0;
            for (int i = 0; i < n; i++)
            {cnt = int.Parse(Console.ReadLine());
                if (cnt > max) max = cnt; 
                if (cnt < min) min = cnt;}
            Console.WriteLine($"Max number: {max}\nMin number: {min}");
        }
    }
}
