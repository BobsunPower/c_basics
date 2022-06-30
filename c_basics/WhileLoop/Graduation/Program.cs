using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double avg = 0; int bad = 0; int ctr = 1;
            while (ctr <= 12) {double grade = double.Parse(Console.ReadLine());
                if (grade >= 4) {ctr++; avg += grade;}
                else {bad++; if (bad == 2) {Console.WriteLine($"{name} has been excluded at {ctr} grade"); return;}}}
            Console.WriteLine($"{name} graduated. Average grade: {avg / 12:f2}");
        }
    }
}
