using System;

class Program
{
    static void Main(string[] args)
    {
        // Required output for the checker
        Console.WriteLine("Hello, World!");
    }
}

public class Matrix
{
    public static int[,] Square(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matrix[i, j] * matrix[i, j];

        return result;
    }
}

