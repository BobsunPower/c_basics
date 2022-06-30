using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int climbers = 0;
            double[] crews = new double[5];
            for (int i = 0; i < n; i++)
            {int ppl = int.Parse(Console.ReadLine()); climbers += ppl;
                if (ppl < 6) {crews[0] += ppl;}
                else if (ppl < 13) {crews[1] += ppl;}
                else if (ppl < 26) {crews[2] += ppl;}
                else if (ppl < 41) {crews[3] += ppl;}
                else {crews[4] += ppl;}}
            Console.WriteLine($@"{(crews[0] / climbers) * 100:f2}%
{(crews[1] / climbers) * 100:f2}%
{(crews[2] / climbers) * 100:f2}%
{(crews[3] / climbers) * 100:f2}%
{(crews[4] / climbers) * 100:f2}%");
        }
    }
}
