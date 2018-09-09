using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5,5];
            arr[2,2] = 1;
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write(arr[i, j]);
                    if (j != arr.GetLength(1) - 1) {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
