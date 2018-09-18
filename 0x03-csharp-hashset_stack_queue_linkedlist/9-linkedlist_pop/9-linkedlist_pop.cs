using System;
using System.Collections.Generic;


class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedList<int>.Enumerator e = myLList.GetEnumerator();
        e.MoveNext();
        int value = e.Current;
        myLList.RemoveFirst();
        return value;
    }
}
