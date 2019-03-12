using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "3:1")
                {
                    break;
                }

                string[] commands = line.Split(' ').ToArray();

                string commandName = commands[0];


                if (commandName == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex < 0 || startIndex > input.Count - 1)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > input.Count - 1 || endIndex < 0)
                    {
                        endIndex = input.Count - 1;
                    }
                    
                    string mergeElements = "";
                    
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        mergeElements += input[i];
                    }

                    input[startIndex] = mergeElements;
                    input.RemoveRange(startIndex + 1, endIndex - startIndex);
                    
                }
                else if (commandName == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    int partLength = input[index].Length / partitions;

                    List<string> divideElements = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        divideElements.Add(input[index].Substring(i * partLength, partLength));
                    }

                    divideElements.Add(input[index].Substring((partitions) * partLength));
                    
                    input.Remove(input[index]);

                    int j = 0;
                    for (int i = index; i <= (index + partitions) - 1; i++)
                    {
                        input.Insert(i, divideElements[j++]);
                    }
                    
                }

            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
