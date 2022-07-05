using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {            
            string movie = Console.ReadLine(); int student = 0; int standart = 0; int kid = 0;
            while (movie != "Finish") {int places = int.Parse(Console.ReadLine()); int sold = 0; string ticket = Console.ReadLine();
                while (ticket != "End") {sold++;
                    switch (ticket) {
                        case "student": student++; break;
                        case "standard": standart++; break;
                        case "kid": kid++; break;}
                    if (sold == places) break;
                    ticket = Console.ReadLine();}
                Console.WriteLine($"{movie} - {((double)sold / places) * 100:f2}% full.");
                if (ticket == "Finish") break;
                movie = Console.ReadLine();}
            double tickets = student + standart + kid;
            Console.WriteLine($@"Total tickets: {tickets}
{(student / tickets) * 100:f2}% student tickets.
{(standart / tickets) * 100:f2}% standard tickets.
{(kid / tickets) * 100:f2}% kids tickets.");
        }
    }
}
