using System;

namespace PointProcessor
{
    public class Point
    {
        public decimal X { get; private set; }
        public decimal Y { get; private set; }

        public Point(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            Point point = obj as Point;
            return point != null 
                && X == point.X 
                && Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return string.Format("X: {0} Y: {1}", X, Y);
        }
    }
}
