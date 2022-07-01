using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine(); string check = Console.ReadLine(); int ctr = 0;
            while (check != book && check != "No More Books") {check = Console.ReadLine(); ctr++;}
            if (check == book) {Console.WriteLine($"You checked {ctr} books and found it.");}
            else { Console.WriteLine($@"The book you search is not here!
You checked {ctr} books.");}
        }
    }
}
