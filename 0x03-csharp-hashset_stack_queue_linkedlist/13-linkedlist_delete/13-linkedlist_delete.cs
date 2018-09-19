using System;
using System.Collections.Generic;


class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int val = 0;
        foreach (int x in myLList) {
            if (index == 0) {
                val = x;
            }
            index--;
        }
        LinkedListNode<int> node = myLList.Find(val);
        myLList.Remove(node);
    }
}
