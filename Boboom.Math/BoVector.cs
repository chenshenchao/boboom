namespace Boboom.Math;

public struct BoVector
{
    public double X { get; set; }
    public double Y { get; set; }

    public static BoVector operator+(BoVector left, BoVector right)
    {
        return new BoVector {
            X = left.X + right.X,
            Y = left.Y + right.Y,
        };
    }

    public static BoVector operator-(BoVector left, BoVector right)
    {
        return new BoVector
        {
            X = left.X - right.X,
            Y = left.Y - right.Y,
        };
    }
}
