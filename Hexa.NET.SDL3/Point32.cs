namespace Hexa.NET.SDL3
{
    using System;

    public struct Point32 : IEquatable<Point32>
    {
        public int X;
        public int Y;

        public Point32(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is Point32 point && Equals(point);
        }

        public readonly bool Equals(Point32 other)
        {
            return X == other.X &&
                   Y == other.Y;
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public static bool operator ==(Point32 left, Point32 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point32 left, Point32 right)
        {
            return !(left == right);
        }
    }
}