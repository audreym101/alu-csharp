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
    /// <exception cref="NotImplementedException">Thrown when Area() is not implemented</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}