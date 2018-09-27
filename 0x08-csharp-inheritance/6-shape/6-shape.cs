using System;

/// <summary>
/// class shape
/// </summary>
class Shape
{
    /// <summary>
    /// area method
    /// </summary>
    /// <returns>not implemented yet</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// class rectangle that inherits from shape
/// </summary>
class Rectangle : Shape {
    //width
    private int width;
    //height
    private int height;
    public int Width {
        get {
            return this.width;
        } set {
            if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
            else this.width = value;
        }
    }
    public int Height {
        get {
            return this.height;
        } set {
            if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
            else this.height = value;
        }
    }
}