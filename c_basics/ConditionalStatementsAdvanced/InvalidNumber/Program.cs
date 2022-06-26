using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool valid = (n >= 100 && n <= 200 || n == 0);
            if (!valid) {Console.WriteLine("invalid");}
        }
    }
}
