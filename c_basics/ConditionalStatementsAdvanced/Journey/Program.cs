using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination;
            string place;
            double total;
            if (budget <= 100) {destination = "Bulgaria";
                if (season == "summer") {place = "Camp"; total = budget * 0.3;}
                else {place = "Hotel"; total = budget * 0.7;}}
            else if (budget <= 1000) {destination = "Balkans";
                if (season == "summer") {place = "Camp"; total = budget * 0.4;}
                else {place = "Hotel"; total = budget * 0.8;}}
            else {destination = "Europe"; total = budget * 0.9; place = "Hotel";}
            Console.WriteLine($"Somewhere in {destination}\n{place} - {total:f2}");
        }
    }
}
