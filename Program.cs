using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int stopNumber = rows * cols;

            int counter = 0;

            int j = 0;
            int row = 0;
            

            while (counter < rows * cols)
            {
                for (int i = row; i < rows - j; i++)
                {
                    matrix[i, j] = ++counter;
                }

                for (int i = row; i < cols - 1 - j; i++)
                {
                    matrix[(rows - 1) - j, i + 1] = ++counter;
                }

                for (int i = row; i < rows - 1 - j; i++)
                {
                    matrix[rows - (i + 2), cols - 1 - j] = ++counter;
                }

                for (int i = row; i < cols - 2 - j; i++)
                {
                    matrix[row, cols - (i + 2)] = ++counter;
                }
                
                j++;
                row++; 
            }

               
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
