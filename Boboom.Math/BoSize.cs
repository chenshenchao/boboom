namespace Boboom.Math;

public struct BoSize
{
    public double Width { get; set; }
    public double Height { get; set; }

    public static BoSize operator+(BoSize left, BoSize right)
    {
        return new BoSize
        {
            Width = left.Width + right.Width,
            Height = left.Height + right.Height,
        };
    }

    public static BoSize operator-(BoSize left, BoSize right)
    {
        return new BoSize
        {
            Width = left.Width - right.Width,
            Height = left.Height - right.Height,
        };
    }
}