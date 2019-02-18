using System;

namespace MatrixSpiral
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            

            int counter = 0;

            int j = 0;
            int col = 0;


            while (counter < rows * cols)
            {
                for (int i = col; i < cols - j; i++) 
                {
                    matrix[j, i] = ++counter;
                }

                for (int i = col + 1; i < rows - j; i++) 
                {
                    matrix[i, cols - 1 - j] = ++counter;
                }

                for (int i = col; i < rows - 1 - j; i++)  
                {
                    matrix[rows - j - 1, cols - 2 - i] = ++counter;
                }

                for (int i = col; i < cols - 2 - j; i++) 
                {
                    matrix[rows - 2- i, col] = ++counter;
                }

                j++;
                col++;
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
