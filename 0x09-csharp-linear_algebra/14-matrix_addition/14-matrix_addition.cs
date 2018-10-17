using System;


class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int len1 = matrix1.GetLength(1);
        int len2 = matrix2.GetLength(1);
        double[,] mat = new double[len1, len1];
        if ((len1 == 2 && len2 ==2) || (len1 == 3 && len2== 3)) {
            for (int i = 0; i < len1; i++) {
                for (int j = 0; j < len1; j++) {
                    mat[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
            return mat;
        }
        return -1;
    }
}