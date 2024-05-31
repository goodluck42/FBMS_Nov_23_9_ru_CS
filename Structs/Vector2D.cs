namespace Structs;

public struct Vector2D : IComparable
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector2D Add(Vector2D vector)
    {
        var result = new Vector2D();

        result.X = X + vector.X;
        result.Y = Y + vector.Y;

        return result;
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}