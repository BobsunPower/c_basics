using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ptsBefore = int.Parse(Console.ReadLine());
            double pts = ptsBefore;
            double wins = 0;
            for (int i = 0; i < n; i++) {string result = Console.ReadLine();
                switch (result)
                {case "W": pts += 2000; wins++; break;
                 case "F": pts += 1200; break;
                 case "SF": pts += 720; break;}}
            Console.WriteLine($@"Final points: {pts}
Average points: {Math.Floor((pts - ptsBefore) / n)}
{wins / n * 100:f2}%");
        }
    }
}