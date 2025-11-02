using System;
using MyMath;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            // Test case 1: {{98, 0, -12}, {21, 972, 44}, {-727, 60, -2}} / 2
            int[,] matrix1 = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            int[,] result1 = Matrix.Divide(matrix1, 2);
            PrintMatrix(result1);
            return;
        }

        string testCase = args[0];
        
        switch (testCase)
        {
            case "1":
                // Test case 1: {{98, 0, -12}, {21, 972, 44}, {-727, 60, -2}} / 2
                int[,] matrix1 = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
                int[,] result1 = Matrix.Divide(matrix1, 2);
                PrintMatrix(result1);
                break;
                
            case "2":
                // Test case 2: {{98, 0, -12}, {21, 972, 44}, {-727, 60, -2}} / -7
                int[,] matrix2 = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
                int[,] result2 = Matrix.Divide(matrix2, -7);
                PrintMatrix(result2);
                break;
                
            case "3":
                // Test case 3: {{98, 0, -12}, {21, 972, 44}, {-727, 60, -2}} / 0
                int[,] matrix3 = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
                int[,] result3 = Matrix.Divide(matrix3, 0);
                break;
                
            case "4":
                // Test case 4: empty matrix / 4
                int[,] matrix4 = new int[6, 6];
                int[,] result4 = Matrix.Divide(matrix4, 4);
                PrintMatrix(result4);
                break;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        if (matrix == null)
            return;
            
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}