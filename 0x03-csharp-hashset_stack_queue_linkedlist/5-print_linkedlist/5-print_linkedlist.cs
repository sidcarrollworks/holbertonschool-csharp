using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linked = new LinkedList<int>();

        for (int i = 0; i < size; i++) {
            linked.AddLast(i);
        }

        foreach (var x in linked) {
            Console.WriteLine(x);
        }
        return linked;
    }
}
