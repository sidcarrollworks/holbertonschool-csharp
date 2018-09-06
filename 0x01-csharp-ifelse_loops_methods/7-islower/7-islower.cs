using System;

class Character
{
    public static bool IsLower(char c)
    {
        bool lower = false;
        for (int i = 'a'; i <= 'z'; i++)
            if (c == i) lower = true;
        return lower;
    }
}
