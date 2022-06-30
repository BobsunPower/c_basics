using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pwd = Console.ReadLine();
            string check = "";
            while (check != pwd) {check = Console.ReadLine();}
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
