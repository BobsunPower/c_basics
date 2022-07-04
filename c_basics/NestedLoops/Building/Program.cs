using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int frs = int.Parse(Console.ReadLine());
            int rms = int.Parse(Console.ReadLine());
            for (int i = frs; i > 0; i--)
            {for (int j = 0; j < rms; j++)
                {if (i == frs) {Console.Write($"L{i}{j} ");}
                    else if (i % 2 == 0) {Console.Write($"O{i}{j} ");}
                    else {Console.Write($"A{i}{j} ");}}
                Console.WriteLine();
            }
        }
    }
}
