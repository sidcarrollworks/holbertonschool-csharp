using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;

        var unique = new HashSet<int>(myList);
        foreach(int x in unique) {
            sum += x;
        }
        return sum;
    }
}
