using System.Diagnostics;

namespace Euclidean.Math
{
    public static class Arithmetic
    {
        /// <summary>
        /// Iterative version of Euclidean Algorithm
        /// </summary>
        private static int CalculateGCDAlgorithm(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }

                num2 -= num1;
            }

            return num1;
        }

        public static int CalculateGCD(int num1, int num2)
        {
            return CalculateGCD(num1, num2);
        }

        public static int CalculateGCD(int num1, int num2, int num3)
        {
            return CalculateGCD(num1, num2, num3);
        }

        public static int CalculateGCD(int num1, int num2, int num3, int num4)
        {
            return CalculateGCD(num1, num2, num3, num4);
        }

        public static int CalculateGCD(int num1, int num2, int num3, int num4, int num5)
        {
            return CalculateGCD(num1, num2, num3, num4, num5);
        }

        public static int CalculateGCD(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("The number of parameters must exceed 2");
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = System.Math.Abs(numbers[i]);
            }

            int gcd = CalculateGCDAlgorithm(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                gcd = CalculateGCDAlgorithm(gcd, numbers[i]);
            }

            return gcd;
        }

        public static int CalculateGCD(out TimeSpan elapsedTime, params int[] numbers)
        {
            var sw = new Stopwatch();

            sw.Start();
            int output = CalculateGCD(numbers);
            sw.Stop();

            elapsedTime = sw.Elapsed;

            return output;
        }
    }
}
