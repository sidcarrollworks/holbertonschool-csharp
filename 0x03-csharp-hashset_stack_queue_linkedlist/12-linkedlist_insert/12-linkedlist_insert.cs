using System;
using System.Collections.Generic;


class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        int val = 0;
        foreach (int x in myLList) {
            if (x < n) {
                val = x;
            }
        }
        LinkedListNode<int> node = myLList.Find(val);
        myLList.AddAfter(node, 21);
        return node;
    }
}
