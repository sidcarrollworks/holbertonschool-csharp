using System;

/// <summary>
/// check if obj is string
/// </summary>
class Obj
{
    /// <summary>
    /// check if obj is of type int
    /// </summary>
    /// <param name="obj">object to test</param>
    /// <returns>true if int else false</returns>
    public static bool IsOfTypeInt(object obj)
    {
        int c;
        return int.TryParse(obj.ToString(), out c);
    }
}
