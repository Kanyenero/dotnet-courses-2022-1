namespace TriangleClassLibrary
{
    public class Triangle
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
        public double CalculateSquare()
        {
            double halfPerimeter = CalculatePerimeter() / 2.0;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public static Triangle Create(double sideA, double sideB, double sideC)
        {
            ValidateSides(sideA, sideB, sideC);
            ValidateExistCondition(sideA, sideB, sideC);

            return new Triangle(sideA, sideB, sideC);
        }

        private Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private static void ValidateSide(double sideLength, string sideName)
        {
            if (sideLength <= 0)
            {
                throw new ArgumentException($"{sideName} was less or equal Zero");
            }
            if (sideLength == double.PositiveInfinity)
            {
                throw new ArgumentException($"{sideName} was greater than PosInf");
            }
        }

        private static void ValidateSides(double sideA, double sideB, double sideC)
        {
            ValidateSide(sideA, nameof(sideA));
            ValidateSide(sideB, nameof(sideB));
            ValidateSide(sideC, nameof(sideC));
        }

        private static void ValidateExistCondition(double sideA, double sideB, double sideC)
        {
            ValidateExistConditionOneSide(sideA, sideB, sideC);
            ValidateExistConditionOneSide(sideB, sideA, sideC);
            ValidateExistConditionOneSide(sideC, sideA, sideB);
        }

        private static void ValidateExistConditionOneSide(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB + sideC)
            {
                throw new ArgumentException($"Triangle existence condition violated ('{sideA}' was bigger than sum of '{sideB}' and '{sideC}')");
            }
        }

        public override string ToString()
        {
            return $"Side A: {SideA}, Side B: {SideB}, Side C: {SideC}, Perimeter: {CalculatePerimeter()}, Square: {CalculateSquare()}";
        }
    }
}