using System;
using System.Collections.Generic;


class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var set1 = new SortedSet<int>(list1);
        var set2 = new SortedSet<int>(list2);
        

        set1.SymmetricExceptWith(set2);

        var newList = new List<int>(set1);
        
        return newList;
    }
}
