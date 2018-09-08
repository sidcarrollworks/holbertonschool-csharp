using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();

        foreach (var x in myList) {
            if (x % 2 == 0) {
                result.Add(true);
            } else {
                result.Add(false);
            }
        }
        return result;
    }
}
