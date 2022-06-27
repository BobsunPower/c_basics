using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int seats = row * col;
            double total = 0;
            switch (movie) {
                case "Premiere": total = seats * 12.00; break;
                case "Normal": total = seats * 7.50; break;
                case "Discount": total = seats * 5.00; break;
                default: break;}
            Console.WriteLine($"{total:f2} leva");
        }
    }
}
