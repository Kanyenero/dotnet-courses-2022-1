using System;

namespace NewtonRoot
{
    public static class Root
    {
        public static double Calculate(double number, int rootDeg, double eps)
        {
            //TODO: Validator NotNegative

            if (number < 0.0)
            {
                throw new ArgumentException("Parameter 'number' must be positive");
            }
            if (rootDeg < 0)
            {
                throw new ArgumentException("Parameter 'rootDeg' must be positive");
            }
            if (eps <= 0.0 || eps > 0.11)
            {
                throw new ArgumentException("Parameter 'eps' must be positive and less than 0.11");
            }

            double x0;
            double x1 = number / rootDeg;

            do
            {
                x0 = x1;
                x1 = (1.0 / rootDeg) * ((rootDeg - 1) * x0 + number / Pow(x0, rootDeg - 1));
            }
            while (Math.Abs(x1 - x0) > eps);

            return x1;
        }

        public static double CalculateStandard(double number, int rootDeg)
        {
            return Math.Pow(number, 1.0/rootDeg);
        }

        public static double Pow(double number, int degree)
        {
            double result = 1;

            for (int i = 0; i < degree; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}