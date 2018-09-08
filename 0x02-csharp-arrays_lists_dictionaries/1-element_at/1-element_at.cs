using System;


    class Array
    {
        public static int elementAt(int[] array, int index)
        {
            try {
                int element = array[index];
                return element;
            } catch (Exception ex) {
                Console.WriteLine("Index out of range");
                return (-1);
            }
        }
    }