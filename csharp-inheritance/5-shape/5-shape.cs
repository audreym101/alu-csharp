using System;

/// <summary>
/// Base Shape class
/// </summary>
public class Shape
{
    /// <summary>
    /// Virtual method to calculate area
    /// </summary>
    /// <returns>Area of the shape</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}