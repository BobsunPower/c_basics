using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int dif = ((int.Parse(Console.ReadLine()) * 60) + int.Parse(Console.ReadLine())) - ((int.Parse(Console.ReadLine()) * 60) + int.Parse(Console.ReadLine()));
            if (dif >= 0 && dif <= 30) {
                if (dif > 0) {Console.WriteLine($"On time\n{dif} minutes before the start");}
                else {Console.WriteLine("On time");}}
            else if (dif > 30) {
                if (dif > 59) {int hrs = dif / 60; int min = dif % 60;
                    Console.WriteLine($"Early\n{hrs}:{min:d2} hours before the start");}
                else {Console.WriteLine($"Early\n{dif} minutes before the start");}}
            else if (dif < 0) {dif = Math.Abs(dif);
                if (dif > 59) {int hours = dif / 60; int minutes = dif % 60;
                    Console.WriteLine($"Late\n{hours}:{minutes:d2} hours after the start");}
                else Console.WriteLine($"Late\n{dif} minutes after the start");
                }
            }
    }
}
