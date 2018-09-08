using System;
using System.Collections.Generic;


class List
{
    public static void DeleteAt(List<int> myList, int index)
    {
        try {
            myList.Remove(myList[index]);
        } catch (Exception) {
            Console.WriteLine("Index is out of range");
        }
    }
}