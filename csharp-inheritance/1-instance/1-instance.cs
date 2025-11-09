using System;

/// <summary>
/// Class for object instance checking
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if an object is an instance of Array or inherits from Array
    /// </summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if the object is an instance of Array or inherits from Array, False otherwise</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}