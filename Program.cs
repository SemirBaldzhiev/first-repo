using System;
using System.Linq;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int min = arr[j];
                int pos = j;

                for (int i = j+1; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                        pos = i;
                    }
                }
                arr[pos] = arr[j];
                arr[j] = min;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
