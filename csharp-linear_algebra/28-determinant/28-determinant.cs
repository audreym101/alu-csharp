class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int size = matrix.GetLength(0);
        
        if (size != matrix.GetLength(1) || (size != 2 && size != 3))
            return -1;
        
        if (size == 2)
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
               matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
               matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }
}