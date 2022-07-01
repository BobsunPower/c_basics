using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            string cmd = "";
            int badGrades = 0; string task = "";
            var grades = new List<double>(); var tasks = new List<string>();
            while (true) {cmd = Console.ReadLine();
                if (cmd == "Enough") { Console.WriteLine($@"Average score: {grades.Sum() / grades.Count:f2}
Number of problems: {tasks.Count}
Last problem: {task}
"); break; }
                int grade = int.Parse(Console.ReadLine()); grades.Add(grade); task = cmd; tasks.Add(task);
                if (grade < 5) { badGrades++; }
                if (badGrades == limit) {Console.WriteLine($"You need a break, {limit} poor grades."); break;}}
        }
    }
}
