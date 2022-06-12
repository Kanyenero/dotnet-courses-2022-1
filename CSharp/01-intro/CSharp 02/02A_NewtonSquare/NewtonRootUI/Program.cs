using NewtonRoot;

namespace NewtonRootUI
{
    internal class Program
    {
        private static void Main()
        {
            double[] numberRange = { .0, 100.0 };
            int[] degreeRange = { 0, 5 };
            double[] epsilonRange = { .0, .11 };

            const int rangeBeginIndex = 0;
            const int rangeEndIndex = 1;

            ValidateRange(numberRange);
            ValidateRange(degreeRange);
            ValidateRange(epsilonRange);

            Console.WriteLine("Type number. Allowed range [{0}, {1}]: ", numberRange[rangeBeginIndex], numberRange[rangeEndIndex]);
            Console.WriteLine("Type degree. Allowed range [{0}, {1}]: ", degreeRange[rangeBeginIndex], degreeRange[rangeEndIndex]);
            Console.WriteLine("Type epsilon. Allowed range [{0}, {1}]: ", epsilonRange[rangeBeginIndex], epsilonRange[rangeEndIndex]);

            Console.WriteLine("Type number");
            double number = ParseConsoleInput(numberRange);

            Console.WriteLine("Type degree");
            int degree = ParseConsoleInput(degreeRange);

            Console.WriteLine("Type epsilon");
            double epsilon = ParseConsoleInput(epsilonRange);

            double[] data = ProcessData(number, degree, epsilon);
            OutputToConsole(data);
        }

        public static double[] ProcessData(double number, int degree, double epsilon)
        {
            return new[] { Root.Calculate(number, degree, epsilon), Root.CalculateStandard(number, degree) };
        }

        public static void OutputToConsole(double[] roots)
        {
            Console.WriteLine("test NewtonRoot: {0}", roots[0]);
            Console.WriteLine("test StandRoot: {0}", roots[1]);

            double diff = roots[0] - roots[1];

            if (diff > .11)
            {
                Console.WriteLine("Results are not equal with accuracy {0}", diff);
            }
            else
            {
                Console.WriteLine("Results are equal with accuracy {0}", diff);
            }
        }

        public static void ValidateRange(double[] rng)
        {
            if (rng == null)
            {
                throw new ArgumentNullException(nameof(rng));
            }

            if (rng.Length != 2)
            {
                throw new ArgumentException("Range length must equals 2");
            }
        }

        public static void ValidateRange(int[] rng)
        {
            if (rng == null)
            {
                throw new ArgumentNullException(nameof(rng));
            }

            if (rng.Length != 2)
            {
                throw new ArgumentException("Range length must equals 2");
            }
        }

        public static double ParseConsoleInput(double[] allowedRange)
        {
            string? line;

            if ((line = Console.ReadLine()) == null)
            {
                ParseConsoleInput(allowedRange);
            }

            double number = double.Parse(line);

            if (NumberInRange(number, allowedRange))
            {
                return number;
            }

            throw new Exception("The number you entered isn't in the range");
        }

        public static int ParseConsoleInput(int[] allowedRange)
        {
            string? line;

            if ((line = Console.ReadLine()) == null)
            {
                ParseConsoleInput(allowedRange);
            }

            int number = int.Parse(line);

            if (NumberInRange(number, allowedRange))
            {
                return number;
            }

            throw new Exception("The number you entered isn't in the range");
        }

        private static bool NumberInRange(double number, double[] range)
        {
            if (number > range[0] && number < range[1])
            {
                return true;
            }

            return false;
        }

        private static bool NumberInRange(int number, int[] range)
        {
            if (number > range[0] && number < range[1])
            {
                return true;
            }

            return false;
        }
    }
}