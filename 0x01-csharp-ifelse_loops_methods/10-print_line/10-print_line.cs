using System;


class Line
{
    public static void PrintLine(int length)
    {
        if (length < 1)
        {
            Console.WriteLine("");
        }
        else
        {
            string line = new String('_', length);
            Console.WriteLine(line);
        }
    }
}
