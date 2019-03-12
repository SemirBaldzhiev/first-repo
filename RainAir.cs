using System;
using System.Collections.Generic;
using System.Linq;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "I believe I can fly!")
                {
                    break;
                }

                string[] customers = input.Split(' ').ToArray();

                if (customers.Contains("="))
                {
                    string firstCustomer = customers[0];
                    string secondCustomers = customers[2];

                    dict[firstCustomer] = dict[secondCustomers];

                }
                else
                {
                    string customerName = customers[0];
                    int[] flights = customers.Skip(1).Take(customers.Length - 1).Select(int.Parse).ToArray();
                    

                    if (!dict.ContainsKey(customerName))
                    {
                        List<int> temp = new List<int>();

                        for (int i = 0; i < flights.Length; i++)
                        {
                            temp.Add(flights[i]);
                        }

                        dict.Add(customerName, temp);
                    }
                    else
                    {
                        for (int i = 0; i < flights.Length; i++)
                        {
                            dict[customerName].Add(flights[i]);
                        }
                    }
                }
                
            }
            
            foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{item.Key} ::: {string.Join(", ", item.Value.OrderBy(x => x))}");
            }
        }
    }
}
