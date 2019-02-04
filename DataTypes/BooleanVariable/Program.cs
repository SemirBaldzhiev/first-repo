using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            bool yesOrNo = Convert.ToBoolean(str);

            if (yesOrNo)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
