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
    /// <summary>
    /// calculates the area
    /// </summary>
    /// <returns>area</returns>
    public new int Area() {
        return this.height * this.width;
    }

    /// <summary>
    /// overrides the toString method
    /// </summary>
    /// <returns>modified string</returns>
    public override string ToString() {
        return ("[Rectangle] " + this.width + " / " + this.height);
    }
}

/// <summary>
/// class square based off rectangle
/// </summary>
class Square : Rectangle {
    //private size
    private int size;
    //public in size
    public int Size {
        get {
            return this.size;
        } set {
            if (value < 0) throw new ArgumentException("Size must be greater than or equal to 0");
            else {
                this.size = value;
                this.Height = value;
                this.Width = value;
            }
        }
    }
    /// <summary>
    /// override tostring for square
    /// </summary>
    /// <returns>formatted string for square class</returns>
    public override string ToString() {
        return ("[Square] " + this.size + " / " + this.size);
    }
}