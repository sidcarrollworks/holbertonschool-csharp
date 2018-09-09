using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keyList = new List<string>();
        foreach (KeyValuePair<string, string> y in myDict) {
            keyList.Add(y.Key);
        }
        keyList.Sort();
        foreach(string x in keyList) {
            Console.WriteLine("{0}: {1}", x, myDict[x]);
        }
    }
}