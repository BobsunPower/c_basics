using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double sub = double.Parse(Console.ReadLine());
            double shoes = sub * 0.6;
            double kit = shoes * 0.8;
            double ball = kit * 0.25;
            double other = ball * 0.2;
            Console.WriteLine(sub + shoes + kit + ball + other);
        }
    }
}
