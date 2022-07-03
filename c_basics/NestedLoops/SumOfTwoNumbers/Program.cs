using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fst = int.Parse(Console.ReadLine()); int snd = int.Parse(Console.ReadLine()); int mgc = int.Parse(Console.ReadLine());
            int cmb = 0; bool fnd = false;
            for (int i = fst; i <= snd; i++)
            {for (int j = fst; j <= snd; j++) {cmb++;
                    if (i + j == mgc) {Console.WriteLine($"Combination N:{cmb} ({i} + {j} = {mgc})"); fnd = true; break;}}
                if (fnd == true) {break;}}
            if (fnd == false) {Console.WriteLine($"{cmb} combinations - neither equals {mgc}");}
        }
    }
}
