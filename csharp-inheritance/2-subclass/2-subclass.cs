using System;

/// <summary>
/// Class for type inheritance checking
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if derivedType is a subclass of baseType (but not the same type)
    /// </summary>
    /// <param name="derivedType">The type to check</param>
    /// <param name="baseType">The base type to check against</param>
    /// <returns>True if derivedType is a subclass of baseType, False otherwise</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}