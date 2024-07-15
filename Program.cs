


/*Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix*/

using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];

        int value = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = value++;
            }
        }

        Console.WriteLine("The 3x3 matrix is:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
