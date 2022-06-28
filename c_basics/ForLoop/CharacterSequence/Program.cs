using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            int length = txt.Length;
            for (int i = 0; i < length; i++) {Console.WriteLine(txt[i]);}
        }
    }
}
