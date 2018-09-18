using System;
using System.Collections.Generic;


class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        foreach (int x in myLList) {
            if (n == 0) {
                return x;
            }
            n--;
        }
        return 0;
    }
}
