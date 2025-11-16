using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };
        
        double cos = Math.Cos(angle), sin = Math.Sin(angle);
        double[,] rotation = { { cos, -sin }, { sin, cos } };
        double[,] result = new double[2, 2];
        
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    result[i, j] += rotation[i, k] * matrix[k, j];
        
        return result;
    }
}