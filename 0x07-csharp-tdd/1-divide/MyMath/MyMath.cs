using System;

/*
    mymath name space
*/
namespace MyMath
{
    /// <summary>
    /// matrix class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// divides matrix
        /// </summary>
        /// <param name="matrix">matrix to divide</param>
        /// <param name="num">number to divide by</param>
        /// <returns>divided matrix</returns>
        public static int[,] Divide(int[,] matrix, int num){
            int[,] copy = matrix.Clone() as int[,];
            if (num == 0) {
                Console.Write("Num cannot be 0");
                return null;
            }
            if (matrix is null) return null;

            for (int i = 0; i < copy.GetLength(0); i++) {
                for (int j = 0; j < copy.GetLength(1); j++) {
                    copy[i, j] = copy[i, j] / 2;
                }

            }
            return copy;
        }
    }
}
