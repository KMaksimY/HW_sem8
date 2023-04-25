// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = {
            {1, 2},
            {3, 4},
            {5, 6}
        };

        int[,] matrix2 = {
            {7, 8, 9},
            {10, 11, 12}
        };

        int[,] result = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("Resulting matrix:");
        PrintMatrix(result);
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;

                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}\t", matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
}
