using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int bigNum = 0;
        string name = "None";
        foreach (KeyValuePair<string, int> x in myList) {
            if (x.Value > bigNum) {
                bigNum = x.Value;
                name = x.Key;
            }
        }
        return name;
    }
}