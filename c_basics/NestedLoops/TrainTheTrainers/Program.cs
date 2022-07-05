using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine()); int ctr = 0; double all = 0; string presentation;
            while ((presentation = Console.ReadLine()) != "Finish") {double totalGrades = 0;
                for (int i = 1; i <= jury; i++)
                {double grades = double.Parse(Console.ReadLine()); totalGrades += grades; all += grades; ctr++;}
                Console.WriteLine($"{presentation} - {totalGrades / jury:f2}.");}
            Console.WriteLine($"Student's final assessment is {all / ctr:f2}.");
        }
    }
}
