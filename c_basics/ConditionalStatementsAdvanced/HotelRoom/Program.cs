using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            if (month == "May" || month == "October") {studio = nights * 50.0; apartment = nights * 65.0;
                if (nights > 7 && nights < 14) {double discount = studio * 0.05; studio -= discount;}
                else if (nights > 14) {double discount = studio * 0.3; studio -= discount;}}
            else if (month == "June" || month == "September") {studio = nights * 75.2; apartment = nights * 68.7;
                if (nights > 14) {double discount = studio * 0.2; studio -= discount;}}
            else if (month == "July" || month == "August") {studio = nights * 76.0; apartment = nights * 77.0;}
            if (nights > 14) {double discount = apartment * 0.1; apartment -= discount;}
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
