using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            string even;
            double total;
            if (sign == '+') {total = x + y;
                if (total % 2 == 0) {even = "even";}
                else {even = "odd";}
                Console.WriteLine($"{x} {sign} {y} = {total} - {even}");}
            else if (sign == '-') {total = x - y;
                if (total % 2 == 0) {even = "even";}
                else {even = "odd";}
                Console.WriteLine($"{x} {sign} {y} = {total} - {even}");}
            else if (sign == '*') {total = x * y;
                if (total % 2 == 0) {even = "even";}
                else {even = "odd";}
                Console.WriteLine($"{x} {sign} {y} = {total} - {even}");}
            else if (sign == '/') {if (y != 0) {total = (double)x / y;}
                else {Console.WriteLine($"Cannot divide {x} by zero"); return;}
                Console.WriteLine($"{x} {sign} {y} = {total:f2}");}
            else if (sign == '%') {if (y != 0) {total = x % y;}
                else {Console.WriteLine($"Cannot divide {x} by zero"); return;}
                Console.WriteLine($"{x} {sign} {y} = {total}");
            }
        }
    }
}
