using System;

/// <summary>
/// obj class
/// </summary>
class Obj
{
    /// <summary>
    /// checks if obj is instance of array
    /// </summary>
    /// <param name="obj">obj to check</param>
    /// <returns>true if instance otherwise false</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array) return true;
        else return false;
    }
}
