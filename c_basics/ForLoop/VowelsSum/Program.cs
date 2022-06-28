using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            int length = txt.Length;
            int sum = 0;
            for (int i = 0; i < length; i++) {
                switch (txt[i]) {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;}}
            Console.WriteLine(sum);
        }
    }
}
