using System;


class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int len1 = matrix.GetLength(1);
        double[,] mat = new double[len1, len1];
        if (len1 == 2 || len1 == 3) {
            for (int i = 0; i < len1; i++) {
                for (int j = 0; j < len1; j++) {
                    mat[i,j] = matrix[i,j] * scalar;
                }
            }
            return mat;
        }
        return -1;
    }
}
