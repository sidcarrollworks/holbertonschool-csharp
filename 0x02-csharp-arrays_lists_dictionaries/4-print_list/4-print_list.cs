using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size) {
        List<int> myList = new List<int>();
        for (int i = 0; i < size; i++) {
            myList.Add(i);
        }
        Console.WriteLine(String.Join(" ", myList));
        return myList;
    }
}
