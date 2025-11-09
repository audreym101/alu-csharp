using System;

/// <summary>
/// Class for object type checking
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if an object is of type int
    /// </summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if the object is of type int, False otherwise</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}