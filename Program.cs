using System;
using System.Linq;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int density = int.Parse(Console.ReadLine());

            double sumCoefficient = 0;

            for (int i = 0; i < n; i++)
            {
                int[] regionsInformation = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int raindropsCount = regionsInformation[0];
                int squareMeters = regionsInformation[1];

                double regionalCoefficient = raindropsCount / (double)squareMeters;

                sumCoefficient += regionalCoefficient;

            }

            Console.WriteLine("{0:f3}", sumCoefficient / density);

        }
    }
}

