using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); int cnt = 1; bool big = false;
            for (int row = 1; row <= n; row++)
            {for (int col = 1; col <= row; col++)
                {if (cnt > n) {big = true; break;} Console.Write($"{cnt} "); cnt++;}
                if (big) {break;}
                Console.WriteLine();
            }
        }
    }
}
