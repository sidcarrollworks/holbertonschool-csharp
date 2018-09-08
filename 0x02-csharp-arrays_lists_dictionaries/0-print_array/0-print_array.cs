using System;
using System.Linq;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        } else {
            int[] arr = Enumerable.Range(0, size).ToArray();
            for (int i = 0; i < size; i++ ) {
                Console.Write(arr[i].ToString());
                if ( i < size - 1) {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
            return arr;
        }
        
    }
}