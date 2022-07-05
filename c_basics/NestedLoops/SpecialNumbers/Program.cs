using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int fst = 1; fst <= 9; fst++)
            {for (int snd = 1; snd <= 9; snd++)
                {for (int trd = 1; trd <= 9; trd++)
                    {for (int fth = 1; fth <= 9; fth++)
                        {if (n % fst == 0 && n % snd == 0 && n % trd == 0 && n % fth == 0)
                            {Console.Write($"{fst}{snd}{trd}{fth} ");}
                        }
                    }
                }
            }
        }
    }
}
