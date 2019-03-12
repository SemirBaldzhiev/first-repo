using System;
using System.Collections.Generic;
using System.Linq;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            int lastNum = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);

            var list = numbers;

            int index = lastNum;
            int steps = 0;

            
            while (true)
            {
                
                numbers = numbers.Select(x => x - 1).ToList();
                
                if (numbers[index] == 0)
                {
                    break;
                }

                if (numbers.Contains(0))
                {

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == 0)
                        {
                            int pos = numbers.IndexOf(0);
                            numbers[pos] = list[pos];
                        }
                    }

                }

                steps++;

                index = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(steps);

        }
    }
}
