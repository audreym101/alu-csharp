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

/// <summary>
/// Rectangle class that inherits from Shape
/// </summary>
public class Rectangle : Shape
{
    /// <summary>
    /// Private field for width
    /// </summary>
    private int width;
    
    /// <summary>
    /// Private field for height
    /// </summary>
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle
    /// </summary>
    /// <value>The width value</value>
    /// <exception cref="ArgumentException">Thrown when value is negative</exception>
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
    /// Gets or sets the height of the rectangle
    /// </summary>
    /// <value>The height value</value>
    /// <exception cref="ArgumentException">Thrown when value is negative</exception>
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
    /// Calculates the area of the rectangle
    /// </summary>
    /// <returns>The area (width * height)</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle
    /// </summary>
    /// <returns>A formatted string in the format [Rectangle] width / height</returns>
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
    /// <summary>
    /// Private field for size
    /// </summary>
    private int size;

    /// <summary>
    /// Gets or sets the size of the square (sets both width and height)
    /// </summary>
    /// <value>The size value</value>
    /// <exception cref="ArgumentException">Thrown when value is negative</exception>
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

    /// <summary>
    /// Returns a string representation of the square
    /// </summary>
    /// <returns>A formatted string in the format [Square] size / size</returns>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}