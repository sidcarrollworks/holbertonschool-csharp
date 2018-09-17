using System;
using System.Collections.Generic;


class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        var set1 = new HashSet<int>(list1);
        var set2 = new HashSet<int>(list2);
        

        set1.IntersectWith(set2);

        var newList = new List<int>(set1);
        
        return newList;
    }
}
