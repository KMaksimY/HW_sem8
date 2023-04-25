// 

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] array = new int[2, 2, 2];
        Random rand = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = rand.Next(1, 100);
                    Console.WriteLine($"array[{i}][{j}][{k}] = {array[i, j, k]}");
                }
            }
        }
    }
}
