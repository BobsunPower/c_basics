using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt;
            while ((txt = Console.ReadLine()) != "Stop") {Console.WriteLine(txt);}
        }
    }
}
