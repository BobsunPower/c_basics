using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string dtn = "";
            while ((dtn = Console.ReadLine()) != "End") {double bgt = double.Parse(Console.ReadLine()); double tot = 0;
                while (bgt >= tot) {string cmd = Console.ReadLine();
                    if (cmd != "End") {double svg = double.Parse(cmd); tot += svg;}
                    else {break;}
                    if (tot >= bgt) {Console.WriteLine($"Going to {dtn}!"); break;}
                }
            }
        }
    }
}
