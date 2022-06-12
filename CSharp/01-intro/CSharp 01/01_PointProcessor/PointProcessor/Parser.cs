using System;
using System.Globalization;

namespace PointProcessor
{
    public static class Parser
    {
        public static bool TryParsePoint(string line, out Point point)
        {
            decimal x, y;
            string[] lineParts;

            if (TryParseLine(line, out lineParts))
            {
                if(TryParseStringToDecimal(lineParts[0], out x) && TryParseStringToDecimal(lineParts[1], out y))
                {
                    point = new Point(x, y);
                    return true;
                }
            }

            point = null;
            return false;
        }

        private static bool TryParseLine(string line, out string[] lineParts)
        {
            lineParts = null;

            if (string.IsNullOrEmpty(line) || !line.Contains(',') || line.IndexOf(',') != line.LastIndexOf(','))
            {
                return false;
            }

            lineParts = line.Split(',');
            return true;
        }

        private static bool TryParseStringToDecimal(string input, out decimal output)
        {
            return decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out output);
        }
    }
}
