using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine());
            int area = a * b * c; int boxes = 0;
            while (boxes < area) {string cmd = Console.ReadLine();
                if (cmd != "Done") {int add = int.Parse(cmd); boxes += add;}
                else {break;}}
            if (boxes < area) {Console.WriteLine($"{area - boxes} Cubic meters left.");}
            else {Console.WriteLine($"No more free space! You need {boxes - area} Cubic meters more.");}
        }
    }
}
