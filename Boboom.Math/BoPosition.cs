namespace Boboom.Math;

public struct BoPosition
{
    public double X { get; set; }
    public double Y { get; set; }

    public static BoPosition FromVector(BoVector v)
    {
        return new BoPosition
        {
            X = v.X,
            Y = v.Y,
        };
    }

    public BoVector ToVector()
    {
        return new BoVector
        {
            X = this.X,
            Y = this.Y,
        };
    }

    public static BoPosition operator+(BoPosition position, BoSize size)
    {
        return new BoPosition
        {
            
            X = position.X + size.Width,
            Y = position.Y + size.Height,
        };
    }
}
