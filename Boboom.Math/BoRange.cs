namespace Boboom.Math;

public struct BoRange
{
    public double Top { get; set; }
    public double Left { get; set; }
    public double Right { get; set; }
    public double Bottom { get; set; }

    public BoPosition Start
    {
        get
        {
            return new BoPosition
            {
                X = Left,
                Y = Top,
            };
        }
    }

    public BoPosition End
    {
        get
        {
            return new BoPosition
            {
                X = Right,
                Y = Bottom,
            };
        }
    }

    public static BoRange operator+(BoRange left, BoRange right)
    {
        return new BoRange
        {
            Top = left.Top + right.Top,
            Left = left.Left + right.Left,
            Right = left.Right + right.Right,
            Bottom = left.Bottom + right.Bottom,
        };
    }

    public static BoRange operator-(BoRange left, BoRange right)
    {
        return new BoRange
        {
            Top = left.Top - right.Top,
            Left = left.Left - right.Left,
            Right = left.Right - right.Right,
            Bottom = left.Bottom - right.Bottom,
        };
    }

    public static BoRange operator*(BoRange left, double right)
    {
        return new BoRange
        {
            Top = left.Top * right,
            Left = left.Left * right,
            Right = left.Right * right,
            Bottom = left.Bottom * right,
        };
    }
}
