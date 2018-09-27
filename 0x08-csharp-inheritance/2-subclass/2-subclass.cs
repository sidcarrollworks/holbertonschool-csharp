using System;

/// <summary>
/// class obj
/// </summary>
class Obj
{
    /// <summary>
    /// checks if subclass
    /// </summary>
    /// <param name="derivedType">potential subclass</param>
    /// <param name="baseType"> base type</param>
    /// <returns>true if subclass false if not</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
