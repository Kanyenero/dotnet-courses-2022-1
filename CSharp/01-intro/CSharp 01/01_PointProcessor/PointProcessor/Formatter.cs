using System;

namespace PointProcessor
{
    public class Formatter
    {
        public static string Format(Point point)
        {
            if (point == null)
            {
                return null;
            }

            int intX = (int)point.X;
            int intY = (int)point.Y;

            decimal fractionX = point.X - intX;
            decimal fractionY = point.Y - intY;

            while (fractionX - Math.Truncate(fractionX) != 0)
            {
                fractionX *= 10;
            }

            while (fractionY - Math.Truncate(fractionY) != 0)
            {
                fractionY *= 10;
            }

            return string.Format("X: {0,4},{1,-4} Y: {2,4},{3,-4}", intX, (int)fractionX, intY, (int)fractionY);
        }
    }
}
