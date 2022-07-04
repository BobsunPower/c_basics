using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int fst = int.Parse(Console.ReadLine()); int snd = int.Parse(Console.ReadLine());
            for (int i = fst; i <= snd; i++) {string num = i.ToString(); int odd = 0; int evn = 0;
                for (int j = 0; j < num.Length; j++) {int dgt = int.Parse(num[j].ToString());
                    if (j % 2 == 0) {evn += dgt;}
                    else {odd += dgt;}}
                if (odd == evn) {Console.Write($"{i} ");}
            }
        }
    }
}
