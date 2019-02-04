using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double obikolka = 2 * a + 2 * b;
            double lice = a * b;
            double diagonal = Math.Sqrt(a*a + b*b);

            Console.WriteLine(obikolka);
            Console.WriteLine(lice);
            Console.WriteLine(diagonal);

        }
    }
}
