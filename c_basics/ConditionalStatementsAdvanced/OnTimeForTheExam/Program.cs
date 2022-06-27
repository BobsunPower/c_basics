using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int ariveHour = int.Parse(Console.ReadLine());
            int ariveMinute = int.Parse(Console.ReadLine());
            int examInMinutes = (examHour * 60) + examMinute;
            int ariveInMinutes = (ariveHour * 60) + ariveMinute;
            int dif = examInMinutes - ariveInMinutes;
            if (dif >= 0 && dif <= 30) {
                if (dif > 0) {Console.WriteLine($"On time\n{dif} minutes before the start");}
                else {Console.WriteLine("On time");}}
            else if (dif > 30) {
                if (dif > 59) {int hours = dif / 60; int minutes = dif % 60;
                    Console.WriteLine($"Early\n{hours}:{minutes:d2} hours before the start");}
                else {Console.WriteLine($"Early\n{dif} minutes before the start");}}
            else if (dif < 0) {dif = Math.Abs(dif);
                if (dif > 59) {int hours = dif / 60; int minutes = dif % 60;
                    Console.WriteLine($"Late\n{hours}:{minutes:d2} hours after the start");}
                else Console.WriteLine($"Late\n{dif} minutes after the start");
                }
            }
    }
}
