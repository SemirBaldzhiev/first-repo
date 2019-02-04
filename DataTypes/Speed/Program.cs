using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            int metri = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());
            int minuti = int.Parse(Console.ReadLine());
            int secundi = int.Parse(Console.ReadLine());

            float seconds = chasove * 60 * 60 + minuti * 60 + secundi;

            float ms = metri / seconds;
            float kmh = (metri / 1000) / ((seconds / 60) / 60);
            float mph = (metri / 1609f) / ((seconds / 60) / 60);

            Console.WriteLine(ms);
            Console.WriteLine(kmh);
            Console.WriteLine(mph);

        }
    }
}
