using System;

namespace HexNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(str, 16));
        }
    }
}
