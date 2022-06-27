using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string dayPart = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (temp >= 10 && temp <= 18) {
                if (dayPart == "Morning") {outfit = "Sweatshirt"; shoes = "Sneakers";}
                else if (dayPart == "Afternoon" || dayPart == "Evening") { outfit = "Shirt"; shoes = "Moccasins";}}
            else if (temp <= 24)
            {if (dayPart == "Morning" || dayPart == "Evening") {outfit = "Shirt";shoes = "Moccasins";}
                else if (dayPart == "Afternoon") {outfit = "T-Shirt"; shoes = "Sandals";}}
            else if (temp >= 25) {
                if (dayPart == "Morning") {outfit = "T-Shirt"; shoes = "Sandals";}
                else if (dayPart == "Afternoon") {outfit = "Swim Suit"; shoes = "Barefoot";}
                else {outfit = "Shirt"; shoes = "Moccasins";}}
            Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
        }
    }
}
