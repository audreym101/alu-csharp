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

/// <summary>
/// Rectangle class that inherits from Shape
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Width property with validation
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Height property with validation
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Calculate area of rectangle
    /// </summary>
    /// <returns>Area of rectangle</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// String representation of rectangle
    /// </summary>
    /// <returns>Formatted string</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>
/// Square class that inherits from Rectangle
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Size property with validation
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Height = value;
            Width = value;
        }
    }
}