using System;


class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        try {
                array[index] = Convert.ToInt32(n);
                return array;
            } catch (Exception) {
                Console.WriteLine("Index out of range");
                return array;
            }
    }
}